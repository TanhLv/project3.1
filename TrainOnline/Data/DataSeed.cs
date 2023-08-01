using TrainOnline.Models;

namespace TrainOnline.Data
{
    public static class DataSeed
    {
        public static void Seeding (ApplicationDbContext context)
        {
            if (context.Types.Count() <= 0)
            {
                var type1 = new _Type()
                {
                    TypeName = "seat",
                    Value = "Type 1",
                    CSSClass = "type1-class",
                    Sorting = "A",
                    StateId = 1
                };

                var type2 = new _Type()
                {
                    TypeName = "traincar",
                    Value = "Type 2",
                    CSSClass = "type2-class",
                    Sorting = "B",
                    StateId = 2
                };

                var type3 = new _Type()
                {
                    TypeName = "train",
                    Value = "Type 3",
                    CSSClass = "type3-class",
                    Sorting = "C",
                    StateId = 3
                };

                var type4 = new _Type()
                {
                    TypeName = "seat",
                    Value = "Type 4",
                    CSSClass = "type4-class",
                    Sorting = "D",
                    StateId = 4
                };

                var type5 = new _Type()
                {
                    TypeName = "traincar",
                    Value = "Type 5",
                    CSSClass = "type5-class",
                    Sorting = "E",
                    StateId = 5
                };

                var type6 = new _Type()
                {
                    TypeName = "train",
                    Value = "Type 6",
                    CSSClass = "type6-class",
                    Sorting = "F",
                    StateId = 6
                };

                var type7 = new _Type()
                {
                    TypeName = "seat",
                    Value = "Type 7",
                    CSSClass = "type7-class",
                    Sorting = "G",
                    StateId = 7
                };

                var type8 = new _Type()
                {
                    TypeName = "traincar",
                    Value = "Type 8",
                    CSSClass = "type8-class",
                    Sorting = "H",
                    StateId = 8
                };

                var type9 = new _Type()
                {
                    TypeName = "train",
                    Value = "Type 9",
                    CSSClass = "type9-class",
                    Sorting = "I",
                    StateId = 9
                };
                context.Types.Add(type1);
                context.Types.Add(type2);
                context.Types.Add(type3);
                context.Types.Add(type4);
                context.Types.Add(type5);
                context.Types.Add(type6);
                context.Types.Add(type7);
                context.Types.Add(type8);
                context.Types.Add(type9);
                context.SaveChanges();
            }

            if (context.Statuses.Count() <= 0)
            {
                var status1 = new _Status()
                {
                    TableName = "Seat",
                    Value = "Status 1",
                    CSSClass = "seat-class",
                    Sorting = "A"
                };

                var status2 = new _Status()
                {
                    TableName = "TrainCar",
                    Value = "Status 2",
                    CSSClass = "traincar-class",
                    Sorting = "B"
                };

                var status3 = new _Status()
                {
                    TableName = "Train",
                    Value = "Status 3",
                    CSSClass = "train-class",
                    Sorting = "C"
                };

                var status4 = new _Status()
                {
                    TableName = "Seat",
                    Value = "Status 4",
                    CSSClass = "seat-class",
                    Sorting = "D"
                };

                var status5 = new _Status()
                {
                    TableName = "TrainCar",
                    Value = "Status 5",
                    CSSClass = "traincar-class",
                    Sorting = "E"
                };

                var status6 = new _Status()
                {
                    TableName = "Train",
                    Value = "Status 6",
                    CSSClass = "train-class",
                    Sorting = "F"
                };

                var status7 = new _Status()
                {
                    TableName = "Seat",
                    Value = "Status 7",
                    CSSClass = "seat-class",
                    Sorting = "G"
                };

                var status8 = new _Status()
                {
                    TableName = "TrainCar",
                    Value = "Status 8",
                    CSSClass = "traincar-class",
                    Sorting = "H"
                };

                var status9 = new _Status()
                {
                    TableName = "Train",
                    Value = "Status 9",
                    CSSClass = "train-class",
                    Sorting = "I"
                };
                context.Statuses.Add(status1);
                context.Statuses.Add(status2);
                context.Statuses.Add(status3);
                context.Statuses.Add(status4);
                context.Statuses.Add(status5);
                context.Statuses.Add(status6);
                context.Statuses.Add(status7);
                context.Statuses.Add(status8);
                context.Statuses.Add(status9);
                context.SaveChanges();
            }

            if (context.Stations.Count() <= 0)
            {
                var station1 = new Station()
                {
                    StationName = "Ga Hà Nội"
                };

                var station2 = new Station()
                {
                    StationName = "Ga Đà Nẵng"
                };

                var station3 = new Station()
                {
                    StationName = "Ga Hồ Chí Minh"
                };

                var station4 = new Station()
                {
                    StationName = "Ga Huế"
                };

                var station5 = new Station()
                {
                    StationName = "Ga Nha Trang"
                };

                var station6 = new Station()
                {
                    StationName = "Ga Đà Lạt"
                };

                context.Stations.Add(station1);
                context.Stations.Add(station2);
                context.Stations.Add(station3);
                context.Stations.Add(station4);
                context.Stations.Add(station5);
                context.Stations.Add(station6);
                context.SaveChanges();
            }

            if (context.Trains.Count () <= 0)
            {
                var train1 = new Train()
                {
                    TrainNumber = 1,
                    TypeId = 3,
                    StatusId = 3
                };

                var train2 = new Train()
                {
                    TrainNumber = 2,
                    TypeId = 6,
                    StatusId = 6
                };

                var train3 = new Train()
                {
                    TrainNumber = 3,
                    TypeId = 9,
                    StatusId = 9
                };

                var train4 = new Train()
                {
                    TrainNumber = 4,
                    TypeId = 3,
                    StatusId = 3
                };

                var train5 = new Train()
                {
                    TrainNumber = 5,
                    TypeId = 6,
                    StatusId = 6
                };

                var train6 = new Train()
                {
                    TrainNumber = 6,
                    TypeId = 9,
                    StatusId = 9
                };

                var train7 = new Train()
                {
                    TrainNumber = 7,
                    TypeId = 3,
                    StatusId = 3
                };

                var train8 = new Train()
                {
                    TrainNumber = 8,
                    TypeId = 6,
                    StatusId = 6
                };

                var train9 = new Train()
                {
                    TrainNumber = 9,
                    TypeId = 9,
                    StatusId = 9
                };

                var train10 = new Train()
                {
                    TrainNumber = 10,
                    TypeId = 3,
                    StatusId = 3
                };

                var train11 = new Train()
                {
                    TrainNumber = 11,
                    TypeId = 6,
                    StatusId = 6
                };

                var train12 = new Train()
                {
                    TrainNumber = 12,
                    TypeId = 9,
                    StatusId = 9
                };

                var train13 = new Train()
                {
                    TrainNumber = 13,
                    TypeId = 3,
                    StatusId = 3
                };

                var train14 = new Train()
                {
                    TrainNumber = 14,
                    TypeId = 6,
                    StatusId = 6
                };

                var train15 = new Train()
                {
                    TrainNumber = 15,
                    TypeId = 9,
                    StatusId = 9
                };

                var train16 = new Train()
                {
                    TrainNumber = 16,
                    TypeId = 3,
                    StatusId = 3
                };

                var train17 = new Train()
                {
                    TrainNumber = 17,
                    TypeId = 6,
                    StatusId = 6
                };

                var train18 = new Train()
                {
                    TrainNumber = 18,
                    TypeId = 9,
                    StatusId = 9
                };

                var train19 = new Train()
                {
                    TrainNumber = 19,
                    TypeId = 3,
                    StatusId = 3
                };

                var train20 = new Train()
                {
                    TrainNumber = 20,
                    TypeId = 6,
                    StatusId = 6
                };

                var train21 = new Train()
                {
                    TrainNumber = 21,
                    TypeId = 9,
                    StatusId = 9
                };

                var train22 = new Train()
                {
                    TrainNumber = 22,
                    TypeId = 3,
                    StatusId = 3
                };

                var train23 = new Train()
                {
                    TrainNumber = 23,
                    TypeId = 6,
                    StatusId = 6
                };

                var train24 = new Train()
                {
                    TrainNumber = 24,
                    TypeId = 9,
                    StatusId = 9
                };

                var train25 = new Train()
                {
                    TrainNumber = 25,
                    TypeId = 3,
                    StatusId = 3
                };

                var train26 = new Train()
                {
                    TrainNumber = 26,
                    TypeId = 6,
                    StatusId = 6
                };

                var train27 = new Train()
                {
                    TrainNumber = 27,
                    TypeId = 9,
                    StatusId = 9
                };

                var train28 = new Train()
                {
                    TrainNumber = 28,
                    TypeId = 3,
                    StatusId = 3
                };

                var train29 = new Train()
                {
                    TrainNumber = 29,
                    TypeId = 6,
                    StatusId = 6
                };

                var train30 = new Train()
                {
                    TrainNumber = 30,
                    TypeId = 9,
                    StatusId = 9
                };

                context.Trains.Add(train1);
                context.Trains.Add(train2);
                context.Trains.Add(train3);
                context.Trains.Add(train4);
                context.Trains.Add(train5);
                context.Trains.Add(train6);
                context.Trains.Add(train7);
                context.Trains.Add(train8);
                context.Trains.Add(train9);
                context.Trains.Add(train10);
                context.Trains.Add(train11);
                context.Trains.Add(train12);
                context.Trains.Add(train13);
                context.Trains.Add(train14);
                context.Trains.Add(train15);
                context.Trains.Add(train16);
                context.Trains.Add(train17);
                context.Trains.Add(train18);
                context.Trains.Add(train19);
                context.Trains.Add(train20);
                context.Trains.Add(train21);
                context.Trains.Add(train22);
                context.Trains.Add(train23);
                context.Trains.Add(train24);
                context.Trains.Add(train25);
                context.Trains.Add(train26);
                context.Trains.Add(train27);
                context.Trains.Add(train28);
                context.Trains.Add(train29);
                context.Trains.Add(train30);
                context.SaveChanges();
            }

            if (context.TrainCars.Count() <= 0)
            {
                var trainCar1 = new TrainCar()
                {
                    TrainCarNumber = 001,
                    TrainId = 1,
                    TypeId = 1,
                    StatusId = 1
                };
            }
        }
    }
}
