using System;
using System.Collections.Generic;
using System.Text;

namespace HAP_DotNet_Core.Model
{
    class Service
    {
        public string DisplayName { get; set; }
        public string UUID { get; set; }
        public string SubType { get; set; }
        public string Iid { get; set; }
        public List<int> Characteristics { get; set; }
        public List<int> OptionalCharacteristics { get; set; }
        public bool IsHiddenService { get; set; }
        public bool IsPrimaryService { get; set; }
        public List<int> LinkedServices { get; set; }

        public Service(string DisplayName, string UUID, string SubType)
        {
            if (UUID.Length == 0) throw new InvalidOperationException("Services must be created with a valid UUID.");

            this.DisplayName = DisplayName;
            this.UUID = UUID;
            this.SubType = SubType;
            this.Iid = null; // assigned later by our containing Accessory
            this.Characteristics = new List<int>();
            this.OptionalCharacteristics = new List<int>();

            this.IsHiddenService = false;
            this.IsPrimaryService = false;
            this.LinkedServices = new List<int>();

            // every service has an optional Characteristic.Name property - we'll set it to our displayName
            // if one was given
            // if you don't provide a display name, some HomeKit apps may choose to hide the device.
            if (DisplayName.Length != 0)
            {
                // create the characteristic if necessary
                //var nameCharacteristic =
                //  this.getCharacteristic(Characteristic.Name) ||
                //  this.addCharacteristic(Characteristic.Name);

                //nameCharacteristic.setValue(DisplayName);
            }
        }
    }
}
