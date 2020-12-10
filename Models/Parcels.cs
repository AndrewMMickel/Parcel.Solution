using System.Collections.Generic;

namespace Parcels.Models
{
    public class Parcel
    {
        private int _width;
        private int _height;
        private int _depth;
        private static List<Parcel> _instances = new List<Parcel>();

        public Parcel(int width, int height, int depth)
        {
            _width = width;
            _height = height;
            _depth = depth;

            _instances.Add(this);
        }

        // Parcel.GetAll()
        public static List<Parcel> GetAll()
        {
            return _instances;
        }

        // newParcel.Volume()
        public int Volume()
        {
            return _width * _height * _depth;
        }

        // newParcel.CostToShip()
        public int CostToShip()
        {
            return Volume() / 3;
        }
    }
}