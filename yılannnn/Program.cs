namespace yılannnn
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            // Uygulama boyunca müziği başlat
            MusicManager.Instance.StartMusic();

            // Ana formu çalıştır
            Application.Run(new name());

            // Uygulama kapanırken müziği durdur
            MusicManager.Instance.StopMusic();



        }
    }
}