using komikaan.GTFS.Models.Static.Enums;

namespace komikaan.GTFS.Extensions
{
    public static class RouteTypeExtensions
    {
        /// <summary>
        /// Converts an extended GTFS route type to its standard equivalent.
        /// </summary>
        /// <returns>An opinionated standard GTFS route type.</returns>
        public static RouteType ToRouteType(this ExtendedRouteType extendedType)
        {
            if (extendedType == ExtendedRouteType.Monorail)
            {
                return RouteType.Monorail;
            }

            if ((int)extendedType >= 100 && (int)extendedType < 200)
            {
                return RouteType.Rail;
            }

            if ((int)extendedType >= 200 && (int)extendedType < 300)
            {
                return RouteType.Bus;
            }
            if ((int)extendedType >= 400 && (int)extendedType < 500)
            {
                return RouteType.Subway;
            }
            if ((int)extendedType >= 700 && (int)extendedType < 800)
            {
                return RouteType.Bus;
            }

            if ((int)extendedType >= 800 && (int)extendedType < 900)
            {
                return RouteType.Bus;
            }
            if ((int)extendedType >= 900 && (int)extendedType < 1000)
            {
                return RouteType.Tram;
            }
            if ((int)extendedType >= 1000 && (int)extendedType < 1100)
            {
                return RouteType.Ferry;
            }
            // Currently defined as "Air service"
            // In reality, these are things like planes, but this is the "closest" equivelant
            // Are you hanging by a cable or is the wind carrying you, same thing
            if ((int)extendedType >= 1100 && (int)extendedType < 1200)
            {
                return RouteType.AerialLift;
            }
            if ((int)extendedType >= 1200 && (int)extendedType < 1300)
            {
                return RouteType.Ferry;
            }
            if ((int)extendedType >= 1300 && (int)extendedType < 1400)
            {
                return RouteType.AerialLift;
            }
            if ((int)extendedType >= 1400 && (int)extendedType < 1500)
            {
                return RouteType.Funicular;
            }
            // Currently defined as "Taxi service"
            // What is a taxi but a bus for <3-7 people
            if ((int)extendedType >= 1500 && (int)extendedType < 1600)
            {
                return RouteType.Bus;
            }
            // "Other" like "Horse"
            // What is a horse but a b.... you get the joke as this point
            if ((int)extendedType >= 1700 && (int)extendedType < 1800)
            {
                return RouteType.Bus;
            }

            return RouteType.Bus;
        }

        /// <summary>
        /// Converts a RouteType to a ExtendedRouteType
        /// </summary>
        /// <returns>A opinionated ExtendedRouteType, tries to be as general as possible</returns>
        public static ExtendedRouteType ToExtendedRouteType(this RouteType routeType)
        {
            switch (routeType)
            {
                case RouteType.Tram:
                    return ExtendedRouteType.TramService;
                case RouteType.Subway:
                    return ExtendedRouteType.MetroService;
                case RouteType.Rail:
                    return ExtendedRouteType.RailwayService;
                case RouteType.Bus:
                    return ExtendedRouteType.BusService;
                case RouteType.Ferry:
                    return ExtendedRouteType.WaterTransportService;
                case RouteType.CableTram:
                    return ExtendedRouteType.CableCarService;
                case RouteType.AerialLift:
                    return ExtendedRouteType.AerialLiftService;
                case RouteType.Funicular:
                    return ExtendedRouteType.FunicularService;
                case RouteType.Trolleybus:
                    return ExtendedRouteType.TrolleybusService;
                case RouteType.Monorail:
                    return ExtendedRouteType.Monorail;
                default:
                    //Assume its a bus if not mapped for some reason
                    return ExtendedRouteType.BusService;
            }
        }
    }
}