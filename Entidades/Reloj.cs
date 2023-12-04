using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reloj
    {
        public delegate void NotificadorCambioTiempo(object reloj, RelojEventArgs infoTiempo);

        public event NotificadorCambioTiempo? SegundoCambiado;

        public CancellationTokenSource? cancelTokenSource;

        public DateTime fechaActual;

        public async Task IniciarRelojAsync(CancellationToken cancelToken)
        {
            cancelTokenSource = new CancellationTokenSource();

            while (!cancelToken.IsCancellationRequested)
            {
                SegundoCambiado?.Invoke(this, new RelojEventArgs(DateTime.Now));

                await Task.Delay(1000, cancelToken);

            }
        }
        public void DetenerReloj()
        {
            cancelTokenSource?.Cancel();
        }
    }
}