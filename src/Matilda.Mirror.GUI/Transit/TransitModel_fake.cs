using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matilda.Mirror.GUI.Transit
{
    internal class TransitModel_fake : TransitModel
    {
        private Random random = new Random();

        public override TimeSpan Interval => TimeSpan.FromSeconds(2);

        public TransitModel_fake() : base()
        {
            this.Lines = new ObservableCollection<TransitLine>()
            {
                new TransitLine
                {
                    RouteName = "1",
                    StopName = "Broadway Westbound",
                    WalkTime = TimeSpan.FromMinutes(5)
                },
                new TransitLine
                {
                    RouteName = "1",
                    StopName = "Broadway EastBound",
                    WalkTime = TimeSpan.FromMinutes(5)
                },
                new TransitLine
                {
                    RouteName = "99",
                    StopName = "Broadway WestBound",
                    WalkTime = TimeSpan.FromMinutes(5)
                },
                new TransitLine
                {
                    RouteName = "99",
                    StopName = "Broadway EastBound",
                    WalkTime = TimeSpan.FromMinutes(5)
                },
            };
        }

        public override void Update()
        {
            var line = Lines[getRandomInt(this.Lines.Count())];
            line.Arrivals.Add(DateTime.Now + TimeSpan.FromMinutes(getRandomInt(10)));
        }

        private int getRandomInt(int maxValue)
        {
            return (int)(random.NextDouble() * maxValue);
        }
    }
}
