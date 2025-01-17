using NITHlibrary.Nith.Module;
using NITHlibrary.Tools.Ports;
using NITHtemplate.Modules;

namespace NITHtemplate.Setups
{
    /// <summary>
    /// The DefaultSetup class is responsible for initializing and configuring the necessary modules and connections for the application.
    /// It manages the creation of various modules such as mapping, rendering, and communication receivers, 
    /// as well as handling cleanup through the Dispose method.
    /// </summary>
    public class DefaultSetup
    {
        /// <summary>
        /// Initializes a new instance of the DefaultSetup class with a specified main window.
        /// </summary>
        /// <param name="window">The main window reference used for rendering.</param>
        public DefaultSetup(MainWindow window)
        {
            Window = window;
            Disposables = new List<IDisposable>();
        }

        private List<IDisposable> Disposables { get; set; }
        private MainWindow Window { get; set; }

        /// <summary>
        /// Launches the setup actions for the application. 
        /// This method initializes various modules, connects them, 
        /// and starts the rendering process for visual output.
        /// </summary>
        public void Setup()
        {
            // Make modules
            Rack.MappingModule = new MappingModule();
            Rack.RenderingModule = new RenderingModule(Window);
            Rack.USBreceiver = new USBreceiver();
            Rack.UDPreceiver = new UDPreceiver();
            Rack.NithModule = new NithModule();

            // Connect USB port to NithModule. Here's an example.
            // Rack.USBreceiver.Connect(3); // Connect the receiver to port 3
            // Rack.USBreceiver.Listeners.Add(Rack.NithModule); // NithModule listens to USB output

            // Add preprocessors. Here's an example:
            // Rack.NithModule.Preprocessors.Add(new NithPreprocessor_FaceCam());

            // Add disposables to list
            Disposables.Add(Rack.RenderingModule);
            Disposables.Add(Rack.USBreceiver);
            Disposables.Add(Rack.UDPreceiver);
            Disposables.Add(Rack.NithModule);

            // Fire the RenderingModule. You will probably want to leave this at the end!
            Rack.RenderingModule.StartRendering();
        }

        /// <summary>
        /// Disposes all the disposable modules to free up resources.
        /// This method should be called upon program exit to ensure proper cleanup.
        /// </summary>
        public void Dispose()
        {
            foreach (IDisposable disposable in Disposables)
            {
                disposable.Dispose();
            }
        }
    }
}