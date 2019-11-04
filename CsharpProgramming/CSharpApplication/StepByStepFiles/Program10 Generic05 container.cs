using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public class ParkingSpaceKey
        {
            private int _floor, _parkingSpace;

            public ParkingSpaceKey( int floor, int parkingSpace )
            {
                _floor = floor;
                _parkingSpace = parkingSpace;
            }

            public class EqualityComparer : IEqualityComparer<ParkingSpaceKey>
            {
                public bool Equals( ParkingSpaceKey x, ParkingSpaceKey y )
                {
                    return x._floor == y._floor && x._parkingSpace == y._parkingSpace;
                }

                public int GetHashCode( ParkingSpaceKey x )
                {
                    return x._floor ^ x._parkingSpace;
                }
            }
            public int GetFloor()
            {
                return _floor;
            }
        }

        static void Main( string[] args )
        {
            Dictionary<ParkingSpaceKey,string>     parkingInfo = new Dictionary<ParkingSpaceKey, string>();
            parkingInfo.Add( new ParkingSpaceKey( 1, 1 ), "car0" );
            parkingInfo.Add( new ParkingSpaceKey( 3, 2 ), "car1" );
            foreach( KeyValuePair<ParkingSpaceKey, string> pair in parkingInfo )
            {
                Console.WriteLine( "{0} {1}", pair.Key.GetFloor(), pair.Value );
            }
        }
    }
}
