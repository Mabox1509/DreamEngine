using OpenTK.Mathematics;
using OpenTK.Windowing.Desktop;
using System;

namespace DreamEngine
{
    public class Core
    {
        #region VARIABLES
        //Window
        private GameWindow window;

        #endregion

        #region METHODS
        public Core(Vector2i size ,int scale = 1, int fps = 60,string title = "My Game") 
        {
            //Set settings
            GameWindowSettings windowSettings = new GameWindowSettings();
            windowSettings.RenderFrequency = fps;
            windowSettings.UpdateFrequency = fps;


            NativeWindowSettings nativeSettings = new NativeWindowSettings();
            nativeSettings.Size = size * scale;
            nativeSettings.MaximumSize = size * scale;
            nativeSettings.MinimumSize = size * scale;
            nativeSettings.Title = title;


            window = new GameWindow(windowSettings, nativeSettings);
            window.CenterWindow();

            window.Load += Window_Load;
            window.Unload += Window_Unload;

            window.UpdateFrame += Window_UpdateFrame;
            window.RenderFrame += Window_RenderFrame;
        }

        

        private void Window_Load()
        {

        }
        private void Window_Unload()
        {

        }


        

        private void Window_UpdateFrame(OpenTK.Windowing.Common.FrameEventArgs obj)
        {

        }
        private void Window_RenderFrame(OpenTK.Windowing.Common.FrameEventArgs obj)
        {

        }

        #endregion
    }
}
