# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## 4.0.3
### Added
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