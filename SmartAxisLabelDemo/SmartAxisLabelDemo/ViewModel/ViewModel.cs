
namespace SmartAxisLabelDemo
{
    public class ViewModel
    {
        public List<Model> Data { get; set; }

        public ViewModel()
        {
            Data = new List<Model>()
            {
                 new Model { Date = new DateTime(2020, 1, 1), SalesRate = 170 },
                 new Model { Date = new DateTime(2020, 2, 1), SalesRate = 180 },
                 new Model { Date = new DateTime(2020, 3, 1), SalesRate = 190 },
                 new Model { Date = new DateTime(2020, 4, 1), SalesRate = 130 },
                 new Model { Date = new DateTime(2020, 5, 1), SalesRate = 140 },
                 new Model { Date = new DateTime(2020, 6, 1), SalesRate = 160 },
                 new Model { Date = new DateTime( 2020, 7, 1), SalesRate = 130 },
                 new Model { Date = new DateTime(2020, 8, 1), SalesRate = 190 },
                 new Model { Date = new DateTime(2020, 9, 1), SalesRate = 160 },
                 new Model { Date = new DateTime(2020, 10, 1), SalesRate = 190 },
                 new Model { Date = new DateTime(2020, 11, 1), SalesRate = 189 },
                 new Model { Date = new DateTime(2020, 12, 1), SalesRate = 190 },
             };
        }
    }
}
