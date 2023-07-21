using System;
using System.Text;
using Vishnu.Interchange;

namespace ConsoleLogger
{
    /// <summary>
    /// Gibt Informationen aus Vishnu auf der Kommandozeile aus.
    /// </summary>
    /// <remarks>
    /// File: ConsoleLogger.cs
    /// Autor: Erik Nagel
    ///
    /// 26.07.2013 Erik Nagel: Erstellt.
    /// 03.07.2021 Erik Nagel: Überarbeitet.
    /// </remarks>
    public class ConsoleLogger : INodeLogger
    {
        #region INodeLogger implementaion

        /// <summary>
        /// Übernahme von diversen Logging-Informationen.
        /// </summary>
        /// <param name="loggerParameters">Spezifische Aufrufparameter oder null.</param>
        /// <param name="treeParameters">Für den gesamten Tree gültige Parameter oder null.</param>
        /// <param name="treeEvent">Objekt mit Informationen über das Ereignis.</param>
        /// <param name="additionalEventArgs">Enthält z.B. beim Event 'Exception' die zugehörige Exception.</param>
        public void Log(object? loggerParameters, TreeParameters? treeParameters, TreeEvent treeEvent, object?additionalEventArgs)
        {
            StringBuilder bigMessage = new StringBuilder(treeEvent.Timestamp.ToString("yyyy-MM-dd HH:mm:ss,ms"));
            bigMessage.Append(" " + treeEvent.Name + ", Thread: " + treeEvent.ThreadId.ToString());
            bigMessage.Append(", Knoten: " + treeEvent.SourceId + "|" + treeEvent.NodeName);
            bigMessage.Append(Environment.NewLine + "           Logical: " + treeEvent.Logical);
            bigMessage.Append(", Status: " + treeEvent.State.ToString());
            Console.WriteLine(bigMessage);
        }

        #endregion INodeLogger implementaion
    }
}
