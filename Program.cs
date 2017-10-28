                                                                                                                //                                                                                               ,...              
//  `7MN.   `7MF'    `7MMF'      .g8"""bgd                         `7MMF'                      .d' ""              
//    MMN.    M        MM      .dP'     `M                           MM                        dM`                 
//    M YMb   M        MM      dM'       `     ,pP"Ybd               MM      `7MMpMMMb.       mMMmm       ,pW"Wq.  
//    M  `MN. M        MM      MM              8I   `"               MM        MM    MM        MM        6W'   `Wb 
//    M   `MM.M        MM      MM.             `YMMMa.               MM        MM    MM        MM        8M     M8 
//    M     YMM        MM      `Mb.     ,'     L.   I8               MM        MM    MM        MM        YA.   ,A9 
//  .JML.    YM      .JMML.      `"bmmmd'      M9mmmP'             .JMML.    .JMML  JMML.    .JMML.       `Ybmd9'  
//                                                                                                              

using System;
using System.Management;

namespace NICs_Info_Console
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Query adapters and list available details
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NetworkAdapter");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject m in queryCollection)
            {
                if (m["Index"] != null)
                {
                    Console.WriteLine("Index : {0}", m["Index"]);
                }
                if (m["Description"] != null)
                {
                    Console.WriteLine("Description : {0}", m["Description"]);
                }
                if (m["NetConnectionID"] != null)
                {
                    Console.WriteLine("NetConnectionID : {0}", m["NetConnectionID"]);
                }
                if (m["AdapterType"] != null)
                {
                    Console.WriteLine("AdapterType : {0}", m["AdapterType"]);
                }
                if (m["AdapterTypeID"] != null)
                {
                    Console.WriteLine("AdapterTypeID : {0}", m["AdapterTypeID"]);
                }
                if (m["AutoSense"] != null)
                {
                    Console.WriteLine("AutoSense : {0}", m["AutoSense"]);
                }
                if (m["Availability"] != null)
                {
                    Console.WriteLine("Availability : {0}", m["Availability"]);
                }
                if (m["Caption"] != null)
                {
                    Console.WriteLine("Caption : {0}", m["Caption"]);
                }
                if (m["ConfigManagerErrorCode"] != null)
                {
                    Console.WriteLine("ConfigManagerErrorCode : {0}", m["ConfigManagerErrorCode"]);
                }
                if (m["ConfigManagerUserConfig"] != null)
                {
                    Console.WriteLine("ConfigManagerUserConfig : {0}", m["ConfigManagerUserConfig"]);
                }
                if (m["CreationClassName"] != null)
                {
                    Console.WriteLine("CreationClassName : {0}", m["CreationClassName"]);
                }
                if (m["DeviceID"] != null)
                {
                    Console.WriteLine("DeviceID : {0}", m["DeviceID"]);
                }
                if (m["ErrorCleared"] != null)
                {
                    Console.WriteLine("ErrorCleared : {0}", m["ErrorCleared"]);
                }
                if (m["ErrorDescription"] != null)
                {
                    Console.WriteLine("ErrorDescription : {0}", m["ErrorDescription"]);
                }
                if (m["GUID"] != null)
                {
                    Console.WriteLine("GUID : {0}", m["GUID"]);
                }
                if (m["InstallDate"] != null)
                {
                    Console.WriteLine("InstallDate : {0}", m["InstallDate"]);
                }
                if (m["Installed"] != null)
                {
                    Console.WriteLine("Installed : {0}", m["Installed"]);
                }
                if (m["InterfaceIndex"] != null)
                {
                    Console.WriteLine("InterfaceIndex : {0}", m["InterfaceIndex"]);
                }
                if (m["LastErrorCode"] != null)
                {
                    Console.WriteLine("LastErrorCode : {0}", m["LastErrorCode"]);
                }
                if (m["MACAddress"] != null)
                {
                    Console.WriteLine("MACAddress : {0}", m["MACAddress"]);
                }
                if (m["Manufacturer"] != null)
                {
                    Console.WriteLine("Manufacturer : {0}", m["Manufacturer"]);
                }
                if (m["MaxNumberControlled"] != null)
                {
                    Console.WriteLine("MaxNumberControlled : {0}", m["MaxNumberControlled"]);
                }
                if (m["MaxSpeed"] != null)
                {
                    Console.WriteLine("MaxSpeed : {0}", m["MaxSpeed"]);
                }
                if (m["Name"] != null)
                {
                    Console.WriteLine("Name : {0}", m["Name"]);
                }
                if (m["NetConnectionStatus"] != null)
                {
                    Console.WriteLine("NetConnectionStatus : {0}", m["NetConnectionStatus"]);
                }
                if (m["NetEnabled"] != null)
                {
                    Console.WriteLine("NetEnabled : {0}", m["NetEnabled"]);
                }                
                //Console.WriteLine("NetworkAddresses : {0}", m["NetworkAddresses[]"]);
                if (m["PermanentAddress"] != null)
                {
                    Console.WriteLine("PermanentAddress : {0}", m["PermanentAddress"]);
                }
                if (m["PhysicalAdapter"] != null)
                {
                    Console.WriteLine("PhysicalAdapter : {0}", m["PhysicalAdapter"]);
                }
                if (m["PNPDeviceID"] != null)
                {
                    Console.WriteLine("PNPDeviceID : {0}", m["PNPDeviceID"]);
                }
                //Console.WriteLine("PowerManagementCapabilities : {0}", m["PowerManagementCapabilities[]"]);
                if (m["PowerManagementSupported"] != null)
                {
                    Console.WriteLine("PowerManagementSupported : {0}", m["PowerManagementSupported"]);
                }
                if (m["ProductName"] != null)
                {
                    Console.WriteLine("ProductName : {0}", m["ProductName"]);
                }
                if (m["ServiceName"] != null)
                {
                    Console.WriteLine("ServiceName : {0}", m["ServiceName"]);
                }
                if (m["Speed"] != null)
                {
                    Console.WriteLine("Speed : {0}", m["Speed"]);
                }
                if (m["Status"] != null)
                {
                    Console.WriteLine("Status : {0}", m["Status"]);
                }
                if (m["StatusInfo"] != null)
                {
                    Console.WriteLine("StatusInfo : {0}", m["StatusInfo"]);
                }
                if (m["SystemCreationClassName"] != null)
                {
                    Console.WriteLine("SystemCreationClassName : {0}", m["SystemCreationClassName"]);
                }
                if (m["SystemName"] != null)
                {
                    Console.WriteLine("SystemName : {0}", m["SystemName"]);
                }
                if (m["TimeOfLastReset"] != null)
                {
                    Console.WriteLine("TimeOfLastReset : {0}", m["TimeOfLastReset"]);
                }
                Console.WriteLine("");
            }
            
            //Availability to disable/enable listed adapters
            Console.WriteLine("Press 'd' to disable all adapters (if running as admin), 'e' to enable all adapters (if running as admin), or any other key to exit...");
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();
            if (cki.Key.ToString() == "d")
            {
                DisableAll();
            }
            else if (cki.Key.ToString() == "e")
            {
                EnableAll();
            }            
        }

        static void EnableAll()
        {
            //Enable all listed adapters
            string interfaceName = "";

            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NetworkAdapter");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject m in queryCollection)
            {
                interfaceName = m["NetConnectionID"].ToString();
                NetshEnable(interfaceName);
            }
        }

        static void DisableAll()
        {
            //Diable all listed adapters
            string interfaceName = "";

            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NetworkAdapter");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject m in queryCollection)
            {
                interfaceName = m["NetConnectionID"].ToString();
                NetshDisable(interfaceName);
            }
        }

        static void NetshEnable(string interfaceName)
        {
            //netsh command to enable interface
            System.Diagnostics.ProcessStartInfo psi =
                    new System.Diagnostics.ProcessStartInfo("netsh", "interface set interface \"" + interfaceName + "\" enable");
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = psi;
            p.Start();
        }

        static void NetshDisable(string interfaceName)
        {
            //netsh command to disable interface
            System.Diagnostics.ProcessStartInfo psi =
                new System.Diagnostics.ProcessStartInfo("netsh", "interface set interface \"" + interfaceName + "\" disable");
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = psi;
            p.Start();
        }
    }
}
