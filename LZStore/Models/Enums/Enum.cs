using System.ComponentModel;

namespace LZStore.Models.Enums
{
    public class Enum
    {

        public enum TipoUsuario : Int16
        {
            Cliente = 1,
            Administrador = 2,
        }

        public enum ModeloProd : Int16
        {
            Torcedor = 1,
            Retro = 2, 
            Jogador = 3,
            Kit = 4,
        }

        public enum TamanhoProd : Int16
        {
            P = 1,
            M = 2,
            G = 3,
            GG = 4,
            XG = 5,
            XXG = 6

        }
    }
}
