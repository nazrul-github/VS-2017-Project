using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStringValues
{
    class Device
    {
        public string Name { get; set; }
        public Device(string deviceName)
        {
            Name = deviceName;
        }

        public string CompanyDevice
        {
            get
            {
                string companyDeviceName;

                switch (Name)
                {
                    case "iPhone": case "iWatch": case "Apple TV": case "iPad":
                        companyDeviceName = "Apple";
                        break;
                    case "Galaxy Note": case "Galaxy S":
                        companyDeviceName = "Samsung";
                        break;
                    default:
                        companyDeviceName = "Unknown";
                        break;
                }
                return companyDeviceName;
            }
        }
    }
}
