using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Timers;
using System.Threading.Tasks;

namespace ServWinGroup1
{
    public partial class Service1 : ServiceBase
    {
        private static Timer aTimer;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            aTimer = new Timer(100000); // 100 sec
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.AutoReset = false;
            aTimer.Enabled = true;

            WriteLogSystem("Démarrage du service ", $"Le service a démarré à {DateTime.Now}");
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            try
            {
                ProcessData().Wait(); // appel asynchrone bloquant
            }
            catch (Exception ex)
            {
                WriteLogSystem(ex.ToString(), "Erreur dans OnTimedEvent");
            }
            finally
            {
                aTimer.Start(); // redémarre le timer
            }
        }

        private static async Task ProcessData()
        {
            try
            {
                try
                {
                    WriteLogSystem("Execution du serice", String.Format("date et heure id :{0}", DateTime.Now));

                }
                catch (Exception ex)
                {

                }

            }
            catch (Exception ex)
            {
                WriteLogSystem(ex.ToString(), "SendMail");
            }
        }

        protected override void OnStop()
        {
            aTimer.Stop();
            aTimer.Dispose();
            WriteLogSystem("Arrêt du service",string.Format("Le service s'est arrêté à {0}",DateTime.Now));
        }

        public static void WriteLogSystem(string erreur, string libelle)
        {
            try
            {
                if (!EventLog.SourceExists("Service Window group1"))
                {
                    EventLog.CreateEventSource("Service Window group1", "Application");
                }

                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = "Service Window group1";
                    eventLog.WriteEntry(
                        $"date: {DateTime.Now}, libelle: {libelle}, description: {erreur}",
                        EventLogEntryType.Information);
                }
            }
            catch (Exception)
            {
                // On ne lance pas d’exception depuis le log système
            }
        }

    }
}
