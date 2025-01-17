﻿using NITHlibrary.Nith.Module;
using NITHlibrary.Tools.Ports;

namespace NITHtemplate.Modules
{
    /// <summary>
    /// The Rack will contain a reference to all the modules and other static objects. 
    /// You can think of it as a scaffold where you place all the stuff you need to connect.
    /// </summary>
    internal static class Rack
    {
        public static MappingModule MappingModule { get; set; }
        public static RenderingModule RenderingModule { get; set; }
        public static USBreceiver USBreceiver { get; set; }
        public static UDPreceiver UDPreceiver { get; set; }
        public static NithModule NithModule { get; set; }

        // Declare here all the other modules!
    }
}