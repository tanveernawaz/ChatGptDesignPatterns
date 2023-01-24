using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGptDesignPatterns
{
    class Connection
    {
        public string ConnectionString { get; set; }
    }

    class ConnectionPool
    {
        private Queue<Connection> _connections;
        private int _poolSize;

        public ConnectionPool(int poolSize)
        {
            _connections = new Queue<Connection>();
            _poolSize = poolSize;
        }

        public Connection GetConnection()
        {
            if (_connections.Count > 0)
                return _connections.Dequeue();
            else
                return null;
        }

        public void ReleaseConnection(Connection connection)
        {
            if (_connections.Count < _poolSize)
                _connections.Enqueue(connection);
        }
    }

    class ConnectionFactory
    {
        public static Connection GetConnectionFromPool(ConnectionPool pool)
        {
            Connection connection = pool.GetConnection();
            if (connection == null)
            {
                connection = new Connection { ConnectionString = "New Connection" };
                Console.WriteLine("Creating new connection");
            }
            else
            {
                Console.WriteLine("Reusing existing connection");
            }
            return connection;
        }

        public static void ReleaseConnectionToPool(ConnectionPool pool, Connection connection)
        {
            pool.ReleaseConnection(connection);
            Console.WriteLine("Connection released to the pool");
        }
    }
}
