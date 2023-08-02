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

            if (context.Trains.Count() == 0)
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

            if (context.TrainCars.Count() <= 0)
            {
                var trainCar1 = new TrainCar()
                {
                    TrainCarNumber = 1,
                    TrainId = 1,
                    TypeId = 3,
                    StatusId = 1
                };
                context.TrainCars.Add(trainCar1);

                var trainCar2 = new TrainCar()
                {
                    TrainCarNumber = 2,
                    TrainId = 1,
                    TypeId = 6,
                    StatusId = 1
                };
                context.TrainCars.Add(trainCar2);

                var trainCar3 = new TrainCar()
                {
                    TrainCarNumber = 3,
                    TrainId = 1,
                    TypeId = 9,
                    StatusId = 1
                };
                context.TrainCars.Add(trainCar3);

                var trainCar4 = new TrainCar()
                {
                    TrainCarNumber = 4,
                    TrainId = 2,
                    TypeId = 3,
                    StatusId = 1
                };
                context.TrainCars.Add(trainCar4);

                var trainCar5 = new TrainCar()
                {
                    TrainCarNumber = 5,
                    TrainId = 2,
                    TypeId = 6,
                    StatusId = 1
                };
                context.TrainCars.Add(trainCar5);

                var trainCar6 = new TrainCar()
                {
                    TrainCarNumber = 6,
                    TrainId = 2,
                    TypeId = 9,
                    StatusId = 1
                };
                context.TrainCars.Add(trainCar6);

                var trainCar7 = new TrainCar()
                {
                    TrainCarNumber = 7,
                    TrainId = 3,
                    TypeId = 3,
                    StatusId = 1
                };
                context.TrainCars.Add(trainCar7);

                var trainCar8 = new TrainCar()
                {
                    TrainCarNumber = 8,
                    TrainId = 3,
                    TypeId = 6,
                    StatusId = 1
                };
                context.TrainCars.Add(trainCar8);

                var trainCar9 = new TrainCar()
                {
                    TrainCarNumber = 9,
                    TrainId = 3,
                    TypeId = 9,
                    StatusId = 1
                };
                context.TrainCars.Add(trainCar9);

                var trainCar10 = new TrainCar()
                {
                    TrainCarNumber = 10,
                    TrainId = 4,
                    TypeId = 3,
                    StatusId = 1
                };
                context.TrainCars.Add(trainCar10);

                var trainCar11 = new TrainCar()
                {
                    TrainCarNumber = 11,
                    TrainId = 4,
                    TypeId = 6,
                    StatusId = 1
                };
                context.TrainCars.Add(trainCar11);

                var trainCar12 = new TrainCar()
                {
                    TrainCarNumber = 12,
                    TrainId = 4,
                    TypeId = 9,
                    StatusId = 1
                };
                context.TrainCars.Add(trainCar12);

                var trainCar13 = new TrainCar()
                {
                    TrainCarNumber = 13,
                    TrainId = 5,
                    TypeId = 3,
                    StatusId = 1
                };
                context.TrainCars.Add(trainCar13);

                var trainCar14 = new TrainCar()
                {
                    TrainCarNumber = 14,
                    TrainId = 5,
                    TypeId = 6,
                    StatusId = 1
                };
                context.TrainCars.Add(trainCar14);

                var trainCar15 = new TrainCar()
                {
                    TrainCarNumber = 15,
                    TrainId = 5,
                    TypeId = 9,
                    StatusId = 1
                };
                context.TrainCars.Add(trainCar15);

                context.SaveChanges();
            }

            if (context.Seats.Count() <= 0)
            {
                var seat1 = new Seat()
                {
                    SeatCode = "A1",
                    TrainCarId = 1,
                    TypeId = 3,
                    StatusId = 1
                };
                context.Seats.Add(seat1);

                var seat2 = new Seat()
                {
                    SeatCode = "A2",
                    TrainCarId = 1,
                    TypeId = 6,
                    StatusId = 1
                };
                context.Seats.Add(seat2);

                var seat3 = new Seat()
                {
                    SeatCode = "A3",
                    TrainCarId = 1,
                    TypeId = 9,
                    StatusId = 1
                };
                context.Seats.Add(seat3);

                var seat4 = new Seat()
                {
                    SeatCode = "A4",
                    TrainCarId = 1,
                    TypeId = 3,
                    StatusId = 1
                };
                context.Seats.Add(seat4);

                var seat5 = new Seat()
                {
                    SeatCode = "A5",
                    TrainCarId = 1,
                    TypeId = 6,
                    StatusId = 1
                };
                context.Seats.Add(seat5);

                var seat6 = new Seat()
                {
                    SeatCode = "B1",
                    TrainCarId = 1,
                    TypeId = 9,
                    StatusId = 1
                };
                context.Seats.Add(seat6);

                var seat7 = new Seat()
                {
                    SeatCode = "B2",
                    TrainCarId = 1,
                    TypeId = 3,
                    StatusId = 1
                };
                context.Seats.Add(seat7);

                var seat8 = new Seat()
                {
                    SeatCode = "B3",
                    TrainCarId = 1,
                    TypeId = 6,
                    StatusId = 1
                };
                context.Seats.Add(seat8);

                var seat9 = new Seat()
                {
                    SeatCode = "B4",
                    TrainCarId = 1,
                    TypeId = 9,
                    StatusId = 1
                };
                context.Seats.Add(seat9);

                var seat10 = new Seat()
                {
                    SeatCode = "B5",
                    TrainCarId = 1,
                    TypeId = 3,
                    StatusId = 1
                };
                context.Seats.Add(seat10);

                var seat11 = new Seat()
                {
                    SeatCode = "C1",
                    TrainCarId = 1,
                    TypeId = 6,
                    StatusId = 1
                };
                context.Seats.Add(seat11);

                var seat12 = new Seat()
                {
                    SeatCode = "C2",
                    TrainCarId = 1,
                    TypeId = 9,
                    StatusId = 1
                };
                context.Seats.Add(seat12);

                var seat13 = new Seat()
                {
                    SeatCode = "C3",
                    TrainCarId = 1,
                    TypeId = 3,
                    StatusId = 1
                };
                context.Seats.Add(seat13);

                var seat14 = new Seat()
                {
                    SeatCode = "C4",
                    TrainCarId = 1,
                    TypeId = 6,
                    StatusId = 1
                };
                context.Seats.Add(seat14);

                var seat15 = new Seat()
                {
                    SeatCode = "C5",
                    TrainCarId = 1,
                    TypeId = 9,
                    StatusId = 1
                };
                context.Seats.Add(seat15);

                var seat16 = new Seat()
                {
                    SeatCode = "D1",
                    TrainCarId = 2,
                    TypeId = 3,
                    StatusId = 1
                };
                context.Seats.Add(seat16);

                var seat17 = new Seat()
                {
                    SeatCode = "D2",
                    TrainCarId = 2,
                    TypeId = 6,
                    StatusId = 1
                };
                context.Seats.Add(seat17);

                var seat18 = new Seat()
                {
                    SeatCode = "D3",
                    TrainCarId = 2,
                    TypeId = 9,
                    StatusId = 1
                };
                context.Seats.Add(seat18);

                var seat19 = new Seat()
                {
                    SeatCode = "D4",
                    TrainCarId = 2,
                    TypeId = 3,
                    StatusId = 1
                };
                context.Seats.Add(seat19);

                var seat20 = new Seat()
                {
                    SeatCode = "D5",
                    TrainCarId = 2,
                    TypeId = 6,
                    StatusId = 1
                };
                context.Seats.Add(seat20);

                var seat21 = new Seat()
                {
                    SeatCode = "E1",
                    TrainCarId = 2,
                    TypeId = 9,
                    StatusId = 1
                };
                context.Seats.Add(seat21);

                var seat22 = new Seat()
                {
                    SeatCode = "E2",
                    TrainCarId = 2,
                    TypeId = 3,
                    StatusId = 1
                };
                context.Seats.Add(seat22);

                var seat23 = new Seat()
                {
                    SeatCode = "E3",
                    TrainCarId = 2,
                    TypeId = 6,
                    StatusId = 1
                };
                context.Seats.Add(seat23);

                var seat24 = new Seat()
                {
                    SeatCode = "E4",
                    TrainCarId = 2,
                    TypeId = 9,
                    StatusId = 1
                };
                context.Seats.Add(seat24);

                var seat25 = new Seat()
                {
                    SeatCode = "E5",
                    TrainCarId = 2,
                    TypeId = 3,
                    StatusId = 1
                };
                context.Seats.Add(seat25);

                var seat26 = new Seat()
                {
                    SeatCode = "F1",
                    TrainCarId = 2,
                    TypeId = 6,
                    StatusId = 1
                };
                context.Seats.Add(seat26);

                var seat27 = new Seat()
                {
                    SeatCode = "F2",
                    TrainCarId = 2,
                    TypeId = 9,
                    StatusId = 1
                };
                context.Seats.Add(seat27);

                var seat28 = new Seat()
                {
                    SeatCode = "F3",
                    TrainCarId = 2,
                    TypeId = 3,
                    StatusId = 1
                };
                context.Seats.Add(seat28);

                var seat29 = new Seat()
                {
                    SeatCode = "F4",
                    TrainCarId = 2,
                    TypeId = 6,
                    StatusId = 1
                };
                context.Seats.Add(seat29);

                var seat30 = new Seat()
                {
                    SeatCode = "F5",
                    TrainCarId = 2,
                    TypeId = 9,
                    StatusId = 1
                };
                context.Seats.Add(seat30);

                var seat31 = new Seat()
                {
                    SeatCode = "G1",
                    TrainCarId = 3,
                    TypeId = 3,
                    StatusId = 1
                };
                context.Seats.Add(seat31);

                var seat32 = new Seat()
                {
                    SeatCode = "G2",
                    TrainCarId = 3,
                    TypeId = 6,
                    StatusId = 1
                };
                context.Seats.Add(seat32);

                var seat33 = new Seat()
                {
                    SeatCode = "G3",
                    TrainCarId = 3,
                    TypeId = 9,
                    StatusId = 1
                };
                context.Seats.Add(seat33);

                var seat34 = new Seat()
                {
                    SeatCode = "G4",
                    TrainCarId = 3,
                    TypeId = 3,
                    StatusId = 1
                };
                context.Seats.Add(seat34);

                var seat35 = new Seat()
                {
                    SeatCode = "G5",
                    TrainCarId = 3,
                    TypeId = 6,
                    StatusId = 1
                };
                context.Seats.Add(seat35);

                var seat36 = new Seat()
                {
                    SeatCode = "H1",
                    TrainCarId = 3,
                    TypeId = 9,
                    StatusId = 1
                };
                context.Seats.Add(seat36);

                var seat37 = new Seat()
                {
                    SeatCode = "H2",
                    TrainCarId = 3,
                    TypeId = 3,
                    StatusId = 1
                };
                context.Seats.Add(seat37);

                var seat38 = new Seat()
                {
                    SeatCode = "H3",
                    TrainCarId = 3,
                    TypeId = 6,
                    StatusId = 1
                };
                context.Seats.Add(seat38);

                var seat39 = new Seat()
                {
                    SeatCode = "H4",
                    TrainCarId = 3,
                    TypeId = 9,
                    StatusId = 1
                };
                context.Seats.Add(seat39);
                context.SaveChanges();
            };
            
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

            if (context.ScheduleDetails.Count() <= 0)
            {
                var scheduleDetail1 = new ScheduleDetail()
                {
                    ScheduleId = 1,
                    CurrentStation = 1,
                    NextStation = 2,
                    PriceToTheNextStation = 10
                };
                context.ScheduleDetails.Add(scheduleDetail1);

                var scheduleDetail2 = new ScheduleDetail()
                {
                    ScheduleId = 2,
                    CurrentStation = 1,
                    NextStation = 3,
                    PriceToTheNextStation = 15
                };
                context.ScheduleDetails.Add(scheduleDetail2);

                var scheduleDetail3 = new ScheduleDetail()
                {
                    ScheduleId = 3,
                    CurrentStation = 3,
                    NextStation = 4,
                    PriceToTheNextStation = 8
                };
                context.ScheduleDetails.Add(scheduleDetail3);

                var scheduleDetail4 = new ScheduleDetail()
                {
                    ScheduleId = 4,
                    CurrentStation = 2,
                    NextStation = 3,
                    PriceToTheNextStation = 12
                };
                context.ScheduleDetails.Add(scheduleDetail4);

                var scheduleDetail5 = new ScheduleDetail()
                {
                    ScheduleId = 5,
                    CurrentStation = 4,
                    NextStation = 5,
                    PriceToTheNextStation = 7
                };
                context.ScheduleDetails.Add(scheduleDetail5);

                var scheduleDetail6 = new ScheduleDetail()
                {
                    ScheduleId = 6,
                    CurrentStation = 5,
                    NextStation = 1,
                    PriceToTheNextStation = 20
                };
                context.ScheduleDetails.Add(scheduleDetail6);

                var scheduleDetail7 = new ScheduleDetail()
                {
                    ScheduleId = 7,
                    CurrentStation = 3,
                    NextStation = 5,
                    PriceToTheNextStation = 18
                };
                context.ScheduleDetails.Add(scheduleDetail7);

                var scheduleDetail8 = new ScheduleDetail()
                {
                    ScheduleId = 8,
                    CurrentStation = 4,
                    NextStation = 6,
                    PriceToTheNextStation = 13
                };
                context.ScheduleDetails.Add(scheduleDetail8);
                context.SaveChanges();
            }

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

            if (context.Passengers.Count() <= 0)
            {
                var passenger1 = new Passenger()
                {
                    Name = "Nguyễn Văn A",
                    Age = 23,
                    Gender = "Nam",
                    PhoneNumber = "0987654321",
                    Email = "nguyenvana@gmail.com",
                    Password = "password",
                    Number = 2
                };
                context.Passengers.Add(passenger1);

                var passenger2 = new Passenger()
                {
                    Name = "Trần Thị B",
                    Age = 30,
                    Gender = "Nữ",
                    PhoneNumber = "0123456789",
                    Email = "tranthib@gmail.com",
                    Password = "password",
                    Number = 1
                };
                context.Passengers.Add(passenger2);

                var passenger3 = new Passenger()
                {
                    Name = "Lê Văn C",
                    Age = 45,
                    Gender = "Nam",
                    PhoneNumber = "0912345678",
                    Email = "levanc@gmail.com",
                    Password = "password",
                    Number = 3
                };
                context.Passengers.Add(passenger3);

                var passenger4 = new Passenger()
                {
                    Name = "Phạm Thị D",
                    Age = 27,
                    Gender = "Nữ",
                    PhoneNumber = "0987654321",
                    Email = "phamthid@gmail.com",
                    Password = "password",
                    Number = 4
                };
                context.Passengers.Add(passenger4);

                var passenger5 = new Passenger()
                {
                    Name = "Hoàng Văn E",
                    Age = 50,
                    Gender = "Nam",
                    PhoneNumber = "0123456789",
                    Email = "hoangvane@gmail.com",
                    Password = "password",
                    Number = 1
                };
                context.Passengers.Add(passenger5);

                var passenger6 = new Passenger()
                {
                    Name = "Nguyễn Thị F",
                    Age = 32,
                    Gender = "Nữ",
                    PhoneNumber = "0912345678",
                    Email = "nguyenthif@gmail.com",
                    Password = "password",
                    Number = 2
                };
                context.Passengers.Add(passenger6);

                var passenger7 = new Passenger()
                {
                    Name = "Trần Văn G",
                    Age = 28,
                    Gender = "Nam",
                    PhoneNumber = "0987654321",
                    Email = "tranvang@gmail.com",
                    Password = "password",
                    Number = 1
                };
                context.Passengers.Add(passenger7);

                var passenger8 = new Passenger()
                {
                    Name = "Lê Thị H",
                    Age = 24,
                    Gender = "Nữ",
                    PhoneNumber = "0123456789",
                    Email = "lethih@gmail.com",
                    Password = "password",
                    Number = 3
                };
                context.Passengers.Add(passenger8);

                var passenger9 = new Passenger()
                {
                    Name = "Phạm Văn I",
                    Age = 35,
                    Gender = "Nam",
                    PhoneNumber = "0912345678",
                    Email = "phamvani@gmail.com",
                    Password = "password",
                    Number = 2
                };
                context.Passengers.Add(passenger9);

                var passenger10 = new Passenger()
                {
                    Name = "Hoàng Thị K",
                    Age = 29,
                    Gender = "Nữ",
                    PhoneNumber = "0987654321",
                    Email = "hoangthik@gmail.com",
                    Password = "password",
                    Number = 1
                };
                context.Passengers.Add(passenger10);

                var passenger11 = new Passenger()
                {
                    Name = "Nguyễn Văn L",
                    Age = 31,
                    Gender = "Nam",
                    PhoneNumber = "0123456789",
                    Email = "nguyenvanl@gmail.com",
                    Password = "password",
                    Number = 3
                };
                context.Passengers.Add(passenger11);

                var passenger12 = new Passenger()
                {
                    Name = "Trần Thị M",
                    Age = 26,
                    Gender = "Nữ",
                    PhoneNumber = "0912345678",
                    Email = "tranthim@gmail.com",
                    Password = "password",
                    Number = 2
                };
                context.Passengers.Add(passenger12);

                context.SaveChanges();
            }

            if (context.Tickets.Count() <= 0)
            {
                var ticket1 = new Ticket()
                {
                    TicketCode = "ABC123",
                    PassengerInformation = 1,
                    TotalTicketPrice = 20000,
                    SeatId = 1,
                    TrainTripId = 1,
                    DepartureStation = 1,
                    ArrivalStation = 2
                };
                context.Tickets.Add(ticket1);

                var ticket2 = new Ticket()
                {
                    TicketCode = "DEF456",
                    PassengerInformation = 2,
                    TotalTicketPrice = 15000,
                    SeatId = 2,
                    TrainTripId = 2,
                    DepartureStation = 1,
                    ArrivalStation = 3
                };
                context.Tickets.Add(ticket2);

                var ticket3 = new Ticket()
                {
                    TicketCode = "GHI789",
                    PassengerInformation = 3,
                    TotalTicketPrice = 24000,
                    SeatId = 3,
                    TrainTripId = 3,
                    DepartureStation = 3,
                    ArrivalStation = 4
                };
                context.Tickets.Add(ticket3);

                var ticket4 = new Ticket()
                {
                    TicketCode = "JKL012",
                    PassengerInformation = 4,
                    TotalTicketPrice = 28000,
                    SeatId = 4,
                    TrainTripId = 4,
                    DepartureStation = 2,
                    ArrivalStation = 3
                };
                context.Tickets.Add(ticket4);

                var ticket5 = new Ticket()
                {
                    TicketCode = "MNO345",
                    PassengerInformation = 5,
                    TotalTicketPrice = 7000,
                    SeatId = 5,
                    TrainTripId = 5,
                    DepartureStation = 4,
                    ArrivalStation = 5
                };
                context.Tickets.Add(ticket5);

                var ticket6 = new Ticket()
                {
                    TicketCode = "PQR678",
                    PassengerInformation = 6,
                    TotalTicketPrice = 40000,
                    SeatId = 6,
                    TrainTripId = 6,
                    DepartureStation = 5,
                    ArrivalStation = 1
                };
                context.Tickets.Add(ticket6);

                var ticket7 = new Ticket()
                {
                    TicketCode = "STU901",
                    PassengerInformation = 7,
                    TotalTicketPrice = 54000,
                    SeatId = 8,
                    TrainTripId = 7,
                    DepartureStation = 3,
                    ArrivalStation = 5
                };
                context.Tickets.Add(ticket7);

                var ticket8 = new Ticket()
                {
                    TicketCode = "VWX234",
                    PassengerInformation = 8,
                    TotalTicketPrice = 26000,
                    SeatId = 7,
                    TrainTripId = 8,
                    DepartureStation = 4,
                    ArrivalStation = 6
                };
                context.Tickets.Add(ticket8);

                var ticket9 = new Ticket()
                {
                    TicketCode = "YZA567",
                    PassengerInformation = 9,
                    TotalTicketPrice = 16000,
                    SeatId = 9,
                    TrainTripId = 1,
                    DepartureStation = 1,
                    ArrivalStation = 2
                };
                context.Tickets.Add(ticket9);

                var ticket10 = new Ticket()
                {
                    TicketCode = "BCD890",
                    PassengerInformation = 10,
                    TotalTicketPrice = 9000,
                    SeatId = 10,
                    TrainTripId = 2,
                    DepartureStation = 1,
                    ArrivalStation = 3
                };
                context.Tickets.Add(ticket10);

                var ticket11 = new Ticket()
                {
                    TicketCode = "EFG123",
                    PassengerInformation = 11,
                    TotalTicketPrice = 32000,
                    SeatId = 11,
                    TrainTripId = 3,
                    DepartureStation = 3,
                    ArrivalStation = 4
                };
                context.Tickets.Add(ticket11);

                var ticket12 = new Ticket()
                {
                    TicketCode = "HIJ456",
                    PassengerInformation = 12,
                    TotalTicketPrice = 21000,
                    SeatId = 12,
                    TrainTripId = 4,
                    DepartureStation = 2,
                    ArrivalStation = 3
                };
                context.Tickets.Add(ticket12);

                context.SaveChanges();
            }

            if (context.Admins.Count() <= 0)
            {
                var admin1 = new Admin()
                {
                    Name = "Thành",
                    Age = 20,
                    Gender = "Nam",
                    PhoneNumber = "0382841374",
                    Email = "dominhthanh31@gmail.com",
                    Password = "Thanh313",
                    Address = "Hà Nội"
                };

                var admin2 = new Admin()
                {
                    Name = "Thế Anh",
                    Age = 20,
                    Gender = "Nam",
                    PhoneNumber = "01234557",
                    Email = "theanh@gmail.com",
                    Password = "1",
                    Address = "Hà Nội"
                };

                var admin3 = new Admin()
                {
                    Name = "Thanh",
                    Age = 20,
                    Gender = "Nam",
                    PhoneNumber = "01234557",
                    Email = "thanh@gmail.com",
                    Password = "1",
                    Address = "Hà Nội"
                };

                var admin4 = new Admin()
                {
                    Name = "Thảo",
                    Age = 20,
                    Gender = "Nam",
                    PhoneNumber = "01234557",
                    Email = "thao@gmail.com",
                    Password = "1",
                    Address = "Hà Nội"
                };

                context.Admins.Add(admin1);
                context.Admins.Add(admin2);
                context.Admins.Add(admin3);
                context.Admins.Add(admin4);
                context.SaveChanges();
            }
        }
    }
}
