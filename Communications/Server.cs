﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using TeachingPlatformApp.Utils;
using TeachingPlatformApp.Models;

namespace TeachingPlatformApp.Communications
{
    public class Server : ITranslateData, IDisposable
    {

        public const int DefaultPort = 16000;

        UdpClient _server;
        
        int _udp720Port = 15000;
        int _wswUdpPort = 14000;

        int _udp720TechingPort = 12000;
        int _udp720TestConsolePort = 11000;

        int _port = DefaultPort;
        string _ip = "192.168.0.132"; //本机Ip;

        string _ipSixPlatform = "192.168.0.131";
        string _ipGunBarrel = "192.168.0.133";
        string _ip720Platform = "192.168.0.134";

        int _sendAfterDelay = 10;

        /// <summary>
        /// 自己电脑IP
        /// </summary>
        public IPAddress IpAddressLocal => IPAddress.Parse(_ip);
        /// <summary>
        /// 六自由度平台Ip
        /// </summary>
        public IPAddress IpAddressSixPlatform => IPAddress.Parse(_ipSixPlatform);
        /// <summary>
        /// 单兵电脑Ip
        /// </summary>
        public IPAddress IpAddressGunBarrel => IPAddress.Parse(_ipGunBarrel);
        /// <summary>
        /// 720度电脑Ip
        /// </summary>
        public IPAddress IpAddress720Platform => IPAddress.Parse(_ip720Platform);

        public IPEndPoint IpEndPointSixPlatform { get; set; }
        public IPEndPoint IpEndPointGunBarrel { get; set; }
        public IPEndPoint IpEndPoint720Platform { get; set; }

        public WswModelInfo PlaneInfo { get; set; }

        public Server()
        {
            PlaneInfo = new WswModelInfo();
            var config = JsonFileConfig.Instance.ComConfig;
            _port = config.SelfPort;
            _udp720Port = config.Udp720Port;
            _wswUdpPort = config.WswUdpPort;
            _ip = config.IpSelf;
            _ipSixPlatform = config.IpWswUdpServer;
            _ipGunBarrel = config.IpGunBarrel;
            _ip720Platform = config.Ip720Platform;
            _udp720TechingPort = config.Udp720TechingPort;
            _udp720TestConsolePort = config.Udp720TestConsolePort;
            _server = new UdpClient(_port);
            IpEndPoint720Platform = new IPEndPoint(IpAddress720Platform, _udp720Port);
            IpEndPointSixPlatform = new IPEndPoint(IpAddressSixPlatform, _wswUdpPort);
            IpEndPointGunBarrel = new IPEndPoint(IpAddressGunBarrel, _wswUdpPort);
        }

        public async Task<int> SendToSixPlatformAsync(byte[] data)
        {
            var result = await _server.SendAsync(data, data.Length,
                new IPEndPoint(IpAddressSixPlatform, _wswUdpPort));
            await Task.Delay(_sendAfterDelay);
            return result;
        }

        public async Task<int> SendToGunBarrelAsync(byte[] data)
        {
            var result = await _server.SendAsync(data, data.Length,
                new IPEndPoint(IpAddressGunBarrel, _wswUdpPort));
            await Task.Delay(_sendAfterDelay);
            return result;
        }

        public async Task<int> SendTo720PlatformAsync(byte[] data)
        {
            var result = await _server.SendAsync(data, data.Length,
                new IPEndPoint(IpAddress720Platform, _wswUdpPort));
            await Task.Delay(_sendAfterDelay);
            return result;
        }
        
        public async Task<int> SendStringToAsync(string str,int num)
        {
            var bytes = Encoding.Default.GetBytes(str);
            await _server.SendAsync(bytes, bytes.Length);
            switch(num)
            {
                case 0:
                    return await SendToSixPlatformAsync(bytes);
                case 1:
                    return await SendToGunBarrelAsync(bytes);
                case 2:
                    return await SendTo720PlatformAsync(bytes);
                default:
                    return await Task.FromResult(-1);
            }
        }

        public void SendToUnity720View(byte[] bytes)
        {
            _server.Send(bytes, bytes.Length, new IPEndPoint(IpAddress720Platform, _udp720TechingPort));
            _server.Send(bytes, bytes.Length, new IPEndPoint(IpAddress720Platform, _udp720TestConsolePort));
        }

        public void SendToGunBarrelWsw(byte[] bytes)
        {
            _server.Send(bytes, bytes.Length, IpEndPointGunBarrel);
        }

        public void SendToSixPlatformWsw(byte[] bytes)
        {
            _server.Send(bytes, bytes.Length, IpEndPointSixPlatform);
        }


        public void SendTo720PlatformWsw(byte[] bytes)
        {
            _server.Send(bytes, bytes.Length, IpEndPoint720Platform);
        }

        public async Task<byte[]> RecieveDataAsync()
        {
            return await Task.Run(() =>
            {
                var ipEndPointnew = new IPEndPoint(IPAddress.Any, 0);
                return _server.Receive(remoteEP: ref ipEndPointnew);
            });
        }

        public async Task<UdpReceiveResult> RecieveAsync()
        {
            return await _server.ReceiveAsync();
        }

        public byte[] Recieve(ref IPEndPoint iPEndPoint)
        {
            return _server.Receive(ref iPEndPoint);
        }

        public void SendTo(byte[] bytes, IPEndPoint iPEndPoint)
        {
            if(bytes != null && iPEndPoint != null)
            {
                _server.Send(bytes, bytes.Length, iPEndPoint);
            }
        }

        ~Server()
        {
            Dispose();
        }

        #region IDisposable Support
        private bool disposedValue = false; // 要检测冗余调用

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    
                }
                if(_server != null)
                {
                    _server.Close();
                    _server = null;
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        #endregion

    }
}
