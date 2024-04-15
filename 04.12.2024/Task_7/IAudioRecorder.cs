using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_7
{
    /// <summary>
    /// Интерфейс для записи и прослушивания звука
    /// </summary>
    public interface IAudioRecorder
    {
        void StartRecording();
        void StopRecording();
    }
    public interface IAudioPlayer
    {
        void Play(string audioFile);
    }
    public interface IAudioManager : IAudioRecorder, IAudioPlayer
    {
    }
}
