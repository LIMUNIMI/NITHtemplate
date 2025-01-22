# NITHtemplate
*A template for the development of NITH applications.*

<div align="center">
  <img src="NithLogo_Black_Trace.png" alt="NITH logo." width="150px"/>
</div>

## Overview
NITHtemplate provides a foundational structure for developing applications dedicated to accessibility for users with motor impairments, using the **NITH framework**. It is designed to facilitate the integration of various components, promoting a modular approach to development.

## Contents
NITHtemplate includes several key classes that developers should customize to fit their application needs.
Some of the predefined contents (such as the placeholder settings in the *Setup* class) provide an example of usage.

### Rack
The **Rack** serves as the central hub of the application. It maintains references to various modules and static objects required for operation. Think of it as a scaffold where all necessary components are organized and connected. Developers can edit this class and add new modules here, making it easy to manage dependencies and interactions between different parts of the application.
Two key classes are MappingModule

### MappingModule
The **MappingModule** is a placeholder for defining interaction strategies and mapping logic. For example, various variables that need some kind of processing, or shared values which should interact together, can be memorized and processed here. While it is optional, using this module allows developers to organize their interaction logic in a tidy manner.

### RenderingModule
The **RenderingModule** is dedicated to managing the graphical rendering operations within the application. It uses a *DispatcherTimer* to trigger rendering updates at specified intervals. This class encapsulates all rendering logic, providing a single point of control for visual output. Developers can customize the rendering behavior by implementing their rendering instructions in designated methods.

### DefaultSetup
The **DefaultSetup** class is responsible for initializing and configuring the application modules. It manages the creation of key components such as the MappingModule, RenderingModule, and port data receivers. This class also handles the connections between various modules, ensuring they can interact seamlessly. Additionally, it includes a cleanup method to properly dispose of resources when the application exits, promoting efficient resource management.

## Getting Started
To get started with NITHtemplate, developers can clone the repository and use this as a starting point for application development. 

### Dependencies
Please clone also the following repositories, and place them in an adjacent folder:

- **NITHlibrary**: https://github.com/LIMUNIMI/NITHlibrary
- **NITHdmis**: https://github.com/LIMUNIMI/NITHdmis
- **NITHemulation**: https://github.com/LIMUNIMI/NITHemulation

### Expanding the template
Please refer to the [NITHlibrary](https://github.com/LIMUNIMI/NITHlibrary) instructions and documentation in order to understand how to use the NITH framework.
A good starting point could be to declare new modules by modifying the code in the *Rack* class. Then, those modules can be instanced in the `DefaultSetup` class, while providing the necessary connections and settings. From there, developers can customize the modules according to their specific requirements.

## License
NITHtemplate is licensed under the [MIT License](LICENSE).
