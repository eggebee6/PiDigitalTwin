# Cyber-Physical Digital Twin for the Raspberry Pi Sense HAT
Put your Sense HAT in the cyber realm!  This project creates a Cyber-Physical Digital Twin for the Sense HAT, demonstrating how the Digital Twin model can be followed to quickly put a Sense HAT online.

See the [GitHub wiki](https://github.com/eggebee6/PiDigitalTwin/wiki) for details on the Cyber-Physical Digital Twin model.

### The setup
All the interesting parts:
- Raspberry Pi 3 B+
- Sense HAT
- Ubuntu for Raspberry Pi (or similar OS)
- C# and .NET Core
- Docker (optional)

Don't forget to install the Sense HAT libraries: *apt get install sense-hat*

### Connecting to the Sense HAT
If a Sense HAT object cannot be instantiated (e.g. if the server is being run on a development machine), a simulation of a Sense HAT generating random sensor data will be used instead.

Using an OPC UA client such as [UaExpert](https://www.unified-automation.com/products/development-tools/uaexpert.html) may be helpful when getting started.  By default, the OPC UA server on the Digital Twin should be accessible at opc.tcp://localhost:43101/UA/PiDigitalTwin or discoverable at opc.tcp://localhost:43101