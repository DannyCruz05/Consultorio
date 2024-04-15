namespace CapaDatos.Core
{
    public interface  iUnitofWork
    {
        iRepository<T> Repository<T>() where T : class;

        int Guardar();
        void ComenzarTransaccion();
        void ReversarTransaccion();
        void ConfirmarTransaccion();
    }
}
