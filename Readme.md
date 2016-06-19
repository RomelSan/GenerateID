# Get ID
Piece of code that shows you how to get the ID from your PC CPU, Drive, Network Card.  
So you can then apply your own license algorithm.

### Requirements
* Net Framework 4.5
* Built on Visual Studio 2015
* Tested on Windows 10

### Features
- [x] Get the CPU ID
- [x] Get Disk Volume Serial
- [x] Get MAC of active Network Adapter
- [x] SHA1 Hash Function
- [x] CPU ID + Disk Serial Combination

### Basic Explanation
##### To get the ID of the PC CPU.  
You should have the class `using System.Management;`
```cs
private string getCPUID()
        {
            string cpuInfo = "";
            ManagementClass managClass = new ManagementClass("win32_processor");
            ManagementObjectCollection managCollec = managClass.GetInstances();

            foreach (ManagementObject managObj in managCollec)
            {
                if (cpuInfo == "")
                {
                    //Get only the first CPU's ID
                    cpuInfo = managObj.Properties["processorID"].Value.ToString();
                    break;
                }
            }

            return cpuInfo;
        }
```
You can get the same result via Command prompt:
`wmic cpu get ProcessorId`

##### To get the Drive serial:  
You should have the class `using System.Management;`  
In this case you can get any serial from any drive example for unit C:  
`textbox1.text = getVolumeSerial("C");`  
Working code is:
```cs
private string getVolumeSerial(string drive)
        {
            ManagementObject disk = new ManagementObject(@"win32_logicaldisk.deviceid=""" + drive + @":""");
            disk.Get();

            string volumeSerial = disk["VolumeSerialNumber"].ToString();
            disk.Dispose();

            return volumeSerial;
        }
```
##### Combination: CPU + Drive
```cs
public string cpu_Drive()
        {
            string volumeSerial = getVolumeSerial("C");
            string cpuID = getCPUID();
            //Mix them up and remove some useless 0's
            return cpuID.Substring(13) + cpuID.Substring(1, 4) + volumeSerial + cpuID.Substring(4, 4);
        }

```
### TO DO
- Nothing yet...

### License
MIT License

### Contact
Twitter: [@RomelSan](http://www.twitter.com/RomelSan)    
Date: June 19, 2016 16:30
