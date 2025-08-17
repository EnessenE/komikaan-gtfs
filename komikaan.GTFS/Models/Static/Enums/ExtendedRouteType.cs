namespace komikaan.GTFS.Models.Static.Enums;

/// <summary>
/// Extended GTFS route types based on Hierarchical Vehicle Type (HVT).
/// <seealso cref="https://developers.google.com/transit/gtfs/reference/extended-route-types"/>
/// </summary>
public enum ExtendedRouteType
{

    // Rail
    RailwayService = 100,
    HighSpeedRailService = 101,
    LongDistanceTrain = 102,
    InterRegionalRailService = 103,
    CarTransportRailService = 104,
    SleeperRailService = 105,
    RegionalRailService = 106,
    TouristRailwayService = 107,
    RailShuttleWithinComplex = 108,
    SuburbanRailway = 109,
    ReplacementRailService = 110,
    SpecialRailService = 111,
    LorryTransportRailService = 112,
    AllRailServices = 113,
    CrossCountryRailService = 114,
    VehicleTransportRailService = 115,
    RackAndPinionRailway = 116,
    AdditionalRailService = 117,

    // Coach
    CoachService = 200,
    InternationalCoachService = 201,
    NationalCoachService = 202,
    ShuttleCoachService = 203,
    RegionalCoachService = 204,
    SpecialCoachService = 205,
    SightseeingCoachService = 206,
    TouristCoachService = 207,
    CommuterCoachService = 208,
    AllCoachServices = 209,

    // Urban Railway / Metro
    UrbanRailwayService = 400,
    MetroService = 401,
    UndergroundService = 402,
    // Note: 403 is also UrbanRailwayService in the provided table, duplicates are not allowed.
    AllUrbanRailwayServices = 404,
    Monorail = 405,

    // Bus
    BusService = 700,
    RegionalBusService = 701,
    ExpressBusService = 702,
    StoppingBusService = 703,
    LocalBusService = 704,
    NightBusService = 705,
    PostBusService = 706,
    SpecialNeedsBus = 707,
    MobilityBusService = 708,
    MobilityBusForRegisteredDisabled = 709,
    SightseeingBus = 710,
    ShuttleBus = 711,
    SchoolBus = 712,
    SchoolAndPublicServiceBus = 713,
    RailReplacementBusService = 714,
    DemandAndResponseBusService = 715,
    AllBusServices = 716,

    // Trolleybus
    TrolleybusService = 800,

    // Tram
    TramService = 900,
    CityTramService = 901,
    LocalTramService = 902,
    RegionalTramService = 903,
    SightseeingTramService = 904,
    ShuttleTramService = 905,
    AllTramServices = 906,

    // Water Transport
    WaterTransportService = 1000,
    AirService = 1100,
    FerryService = 1200,

    // Aerial Lift
    AerialLiftService = 1300,
    TelecabinService = 1301,
    CableCarService = 1302,
    ElevatorService = 1303,
    ChairLiftService = 1304,
    DragLiftService = 1305,
    SmallTelecabinService = 1306,
    AllTelecabinServices = 1307,

    // Funicular
    FunicularService = 1400,

    // Taxi
    TaxiService = 1500,
    CommunalTaxiService = 1501, // Also known as ShareTaxi
    WaterTaxiService = 1502,
    RailTaxiService = 1503,
    BikeTaxiService = 1504,
    LicensedTaxiService = 1505,
    PrivateHireServiceVehicle = 1506,
    AllTaxiServices = 1507,

    // Miscellaneous
    MiscellaneousService = 1700,
    HorseDrawnCarriage = 170
}
