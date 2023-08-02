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

            if (context.Trains.ToList().Count() == 0)
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

                context.Trains.Add(train1);
                context.Trains.Add(train2);
                context.Trains.Add(train3);
                context.Trains.Add(train4);
                context.Trains.Add(train5);
                context.SaveChanges();
            }

            //if (context.TrainCars.Count() <= 0)
            //{
            //    // Các giá trị cho typeId, statusId và trainId
            //    int[] typeIds = { 3, 6, 9 };
            //    int[] statusIds = { 3, 6, 9 };
            //    int[] trainIds = { 1, 2, 3, 4, 5 };

            //    for (int i = 0; i < 25; i++)
            //    {
            //        var trainCar = new TrainCar()
            //        {
            //            TrainCarNumber = i + 1, // Giá trị TrainCarNumber tăng dần từ 1 đến 25
            //            TrainId = trainIds[i % trainIds.Length], // Lặp lại các giá trị trainIds
            //            TypeId = typeIds[i % typeIds.Length], // Lặp lại các giá trị typeIds
            //            StatusId = statusIds[i % statusIds.Length] // Lặp lại các giá trị statusIds
            //        };

            //        context.TrainCars.Add(trainCar);
            //    }

            //    context.SaveChanges();
            //}

            //if (context.Seats.Count() <= 0)
            //{
            //    // Các giá trị cho typeId và statusId
            //    int[] typeIds = { 3, 6, 9 };
            //    int[] statusIds = { 3, 6, 9 };

            //    // Số lượng các TrainCarId
            //    int trainCarIdCount = 25;

            //    // Số lượng dữ liệu cần thêm
            //    int dataCount = 30;

            //    int dataIndex = 0; // Biến đếm cho dữ liệu

            //    for (int i = 1; i <= trainCarIdCount; i++)
            //    {
            //        for (int j = 0; j < dataCount / trainCarIdCount; j++)
            //        {
            //            var seat = new Seat()
            //            {
            //                SeatCode = $"Seat-{dataIndex + 1}", // Giá trị SeatCode của bạn
            //                TrainCarId = i, // Lặp lại các giá trị TrainCarId từ 1 đến trainCarIdCount
            //                TypeId = typeIds[dataIndex % typeIds.Length], // Lặp lại các giá trị typeIds
            //                StatusId = statusIds[dataIndex % statusIds.Length] // Lặp lại các giá trị statusIds
            //            };

            //            context.Seats.Add(seat);

            //            dataIndex++;
            //        }
            //    }

            //    context.SaveChanges();
            //}

            if (context.Schedules.Count() <= 0)
            {
                string[] scheduleNames = { "Hà Nội", "Đà Nẵng", "Hồ Chí Minh", "Huế", "Nha Trang", "Đà Lạt" };

                for (int i = 0; i < 8; i++)
                {
                    var schedule = new Schedule()
                    {
                        ScheduleName = $"{scheduleNames[i % scheduleNames.Length]} - {scheduleNames[(i + 1) % scheduleNames.Length]}"
                    };

                    context.Schedules.Add(schedule);
                }

                context.SaveChanges();
            }

            //if (context.ScheduleDetails.Count() <= 0)
            //{
            //    var scheduleDetail = new ScheduleDetail()
            //    {
            //        ScheduleId = 1,
            //        CurrentStation = 1,
            //        NextStation = 1,
            //        PriceToTheNextStation = 1
            //    };
            //    context.ScheduleDetails.Add(scheduleDetail);
            //    context.SaveChanges();
            //}

            if (context.TrainTrips.Count() <= 0)
            {
                var trainTrip1 = new TrainTrip()
                {
                    TrainTripCode = "TT002",
                    TrainId = 2,
                    ScheduleId = 3,
                    DepartureTime = new DateTime(2023, 8, 2, 15, 30, 0),
                    ArrivalTime = new DateTime(2023, 8, 2, 17, 0, 0)
                };

                var trainTrip2 = new TrainTrip()
                {
                    TrainTripCode = "TT003",
                    TrainId = 1,
                    ScheduleId = 2,
                    DepartureTime = new DateTime(2023, 8, 3, 8, 0, 0),
                    ArrivalTime = new DateTime(2023, 8, 3, 11, 0, 0)
                };

                var trainTrip3 = new TrainTrip()
                {
                    TrainTripCode = "TT004",
                    TrainId = 4,
                    ScheduleId = 1,
                    DepartureTime = new DateTime(2023, 8, 4, 12, 30, 0),
                    ArrivalTime = new DateTime(2023, 8, 4, 15, 0, 0)
                };

                var trainTrip4 = new TrainTrip()
                {
                    TrainTripCode = "TT005",
                    TrainId = 5,
                    ScheduleId = 7,
                    DepartureTime = new DateTime(2023, 8, 5, 10, 0, 0),
                    ArrivalTime = new DateTime(2023, 8, 5, 13, 30, 0)
                };

                var trainTrip5 = new TrainTrip()
                {
                    TrainTripCode = "TT006",
                    TrainId = 3,
                    ScheduleId = 6,
                    DepartureTime = new DateTime(2023, 8, 6, 14, 0, 0),
                    ArrivalTime = new DateTime(2023, 8, 6, 17, 0, 0)
                };

                var trainTrip6 = new TrainTrip()
                {
                    TrainTripCode = "TT007",
                    TrainId = 2,
                    ScheduleId = 4,
                    DepartureTime = new DateTime(2023, 8, 7, 9, 0, 0),
                    ArrivalTime = new DateTime(2023, 8, 7, 11, 0, 0)
                };

                var trainTrip7 = new TrainTrip()
                {
                    TrainTripCode = "TT008",
                    TrainId = 1,
                    ScheduleId = 8,
                    DepartureTime = new DateTime(2023, 8, 8, 16, 0, 0),
                    ArrivalTime = new DateTime(2023, 8, 8, 17, 30, 0)
                };

                var trainTrip8 = new TrainTrip()
                {
                    TrainTripCode = "TT009",
                    TrainId = 4,
                    ScheduleId = 2,
                    DepartureTime = new DateTime(2023, 8, 9, 11, 30, 0),
                    ArrivalTime = new DateTime(2023, 8, 9, 13, 30, 0)
                };

                context.TrainTrips.Add(trainTrip1);
                context.TrainTrips.Add(trainTrip2);
                context.TrainTrips.Add(trainTrip3);
                context.TrainTrips.Add(trainTrip4);
                context.TrainTrips.Add(trainTrip5);
                context.TrainTrips.Add(trainTrip6);
                context.TrainTrips.Add(trainTrip7);
                context.TrainTrips.Add(trainTrip8);
                context.SaveChanges();
            }
        }
    }
}
