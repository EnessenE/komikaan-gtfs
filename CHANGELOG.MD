# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## 4.5.0
- Add models for all remaining GTFS Schedule files: pathways.txt, levels.txt, attributions.txt, translations.txt, rider_categories.txt, fare_media.txt, fare_products.txt, fare_leg_rules.txt, fare_leg_join_rules.txt, fare_transfer_rules.txt, timeframes.txt, areas.txt, stop_areas.txt, networks.txt, route_networks.txt, location_groups.txt, location_group_stops.txt, booking_rules.txt and locations.geojson (GTFS-Flex)
- Add `safe_duration_factor` and `safe_duration_offset` to `Trip` (April 2026 spec revision)
- Add `from_route_id`, `to_route_id`, `from_trip_id`, `to_trip_id` to `Transfer`, and `InSeat` (4) / `InSeatNotAllowed` (5) to `TransferType`
- Add GTFS-Flex fields to `StopTime`: `location_group_id`, `location_id`, `start_pickup_drop_off_window`, `end_pickup_drop_off_window`, `pickup_booking_rule_id`, `drop_off_booking_rule_id`
- New enums: `PathwayMode`, `Bidirectional`, `BookingType`, `FareMediaType`, `FareTransferType`, `DurationLimitType`, `AttributionRole`, `DefaultFareCategory`
- CI pipeline now packs and uploads the `.nupkg` as a workflow artifact
- Multi-target `net8.0`, `net10.0` and `netstandard2.1` (netstandard2.1 gets `System.Text.Json` as a package dependency and small polyfills for `DateOnly` and the `required` modifier attributes, so the public API is identical on all targets)
- CI installs both the .NET 8 and .NET 10 SDKs

## 4.4.2
- Fix parsing feeds where `TripDescriptor` field 7 (`modified_trip`) is a plain string instead of a `ModifiedTripSelector` message (e.g. opentransportdata.swiss), which made protobuf-net throw `Invalid wire-type`. Field 7 is now captured as raw bytes in `ModifiedTripRaw`, with computed `ModifiedTrip` (message form) and `ModifiedTripId` (string form) views.
- Add CI pipeline (`.github/workflows/build.yml`) verifying Debug/Release builds and package artifacts on ubuntu/windows, plus regression tests (`komikaan.GTFS.Tests`) covering feeds with string-form and message-form `modified_trip`.

## 4.4.1
- Fix CongestionLevel, DropOffPickupType, Incrementality, SeverityLevel, StopTimeScheduleRelationShip, TripScheduleRelationShip and VehicleStopStatus enums to match GTFS spec set values
- Issue above was primarly relevant for TripScheduleRelationShip due to the passive order of the ENUM's already guaranteeing parsing went well
- 
## 4.4.0
- Include Protobuf core for attributes

## 4.3.0
- HorseDrawnCarrage extended route type was set to 170, this should have been 1702
- Update to October 2025 GTFS Static spec https://gtfs.org/documentation/schedule/change-history/revision-history/#october-2025
 - Added cemv_support field to Agency and Trip
 - Added stop_access field to Stop

## 4.2.0
- GTFS Extended Route Types support
- Add ExtendedRouteType to Route object
- Add ToExtendedRouteType() and ToRouteType() extensions

## 4.1.1
- nuget.org bugfix

## 4.1.0
- Update to June 2025 GTFS Static spec
  - Added cars_allowed to Trips
- Set timepoint as nullable

## 4.0.4
### Changed
- Make items in Calendar, Route, Shape and Trip nullable where needed
- Make StartDate and EndDate in Calendar a DateOnly
- Make all "days" in Calendar a boolean

## 4.0.3
### Changed
- Make items in CalendarDate, Stop and StopTime nullable where needed
- Make Date in CalendarDate a DateOnly

## 4.0.1
### Added
- All realtime objects inherit from GTFSRealtimeObject
- All static objects inherit from GTFSStaticObject
- A NUPGK package is now generated on build

### Changed
## 4.0.0
- We are re-using a old package name
### Added
- Add GTFS static models that are up to date to latest GTFS revision published on April 2025
- Add GTFS realtime models that are up to date to latest GTFS revision published on May 2025