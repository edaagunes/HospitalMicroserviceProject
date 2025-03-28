﻿using StackExchange.Redis;

namespace Hospital.Prescription.Settings
{
	public class RedisService
	{
		private ConnectionMultiplexer _connectionMultiplexer;
		public string _host { get; set; }
		public int _port { get; set; }

		public RedisService(string host, int port)
		{
			_host = host;
			_port = port;
		}

		public void Connect() => _connectionMultiplexer = ConnectionMultiplexer.Connect($"{_host}:{_port}");
		public IDatabase GetDb(int db = 1) => _connectionMultiplexer.GetDatabase(0);
	}
}
