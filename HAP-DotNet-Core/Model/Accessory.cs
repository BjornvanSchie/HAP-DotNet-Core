using System;
using System.Collections.Generic;
using System.Text;
using HAP_DotNet_Core.Utils;

namespace HAP_DotNet_Core.Interfaces
{
    class Accessory
    {
        string DisplayName { get; set; }
        string UUID { get; set; }
        string Aid { get; set; }
        string Pincode { get; set; }
        string Username { get; set; }
        string Manufacturer { get; set; }
        string Model { get; set; }
        string SerialNumber { get; set; }
        int Category { get; set; }
        bool Reachable { get; set; }
        string CameraSource { get; set; }
        bool ShouldPurgeUnusedIDs { get; set; }
        List<int> Services { get; set; }

        public enum Categories
        {
            OTHER = 1,
            BRIDGE = 2,
            FAN = 3,
            GARAGE_DOOR_OPENER = 4,
            LIGHTBULB = 5,
            DOOR_LOCK = 6,
            OUTLET = 7,
            SWITCH = 8,
            THERMOSTAT = 9,
            SENSOR = 10,
            ALARM_SYSTEM = 11,
            SECURITY_SYSTEM = 11, //Added to conform to HAP naming
            DOOR = 12,
            WINDOW = 13,
            WINDOW_COVERING = 14,
            PROGRAMMABLE_SWITCH = 15,
            RANGE_EXTENDER = 16,
            CAMERA = 17,
            IP_CAMERA = 17, //Added to conform to HAP naming
            VIDEO_DOORBELL = 18,
            AIR_PURIFIER = 19,
            AIR_HEATER = 20, //Not in HAP Spec
            AIR_CONDITIONER = 21, //Not in HAP Spec
            AIR_HUMIDIFIER = 22, //Not in HAP Spec
            AIR_DEHUMIDIFIER = 23, // Not in HAP Spec
            APPLE_TV = 24,
            SPEAKER = 26,
            AIRPORT = 27,
            SPRINKLER = 28,
            FAUCET = 29,
            SHOWER_HEAD = 30
        }

        public Accessory(string DisplayName, string UUID)
        {
            if (DisplayName.Length == 0) throw new InvalidOperationException("Accessories must be created with a non-empty displayName.");
            if (UUID.Length == 0) throw new InvalidOperationException("Accessories must be created with a valid UUID.");
            if (!UUIDHelper.IsValid(UUID)) throw new InvalidOperationException("UUID is not a valid UUID. Try using the provided 'generateUUID' function to create a valid UUID from any arbitrary string, like a serial number.");


            this.DisplayName = DisplayName;
            this.UUID = UUID;
            this.Aid = null; // assigned by us in assignIDs()
            this.Reachable = true;
            this.Category = (int)Categories.OTHER;
            this.CameraSource = null;
            this.Services = new List<int>();
            this.ShouldPurgeUnusedIDs = true; // Purge unused ids by default

            // create our initial "Accessory Information" Service that all Accessories are expected to have


        }
    }
}
