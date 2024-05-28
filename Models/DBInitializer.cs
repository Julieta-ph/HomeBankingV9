namespace HomeBankingV9.Models
{
    public class DBInitializer
    {

        //funciones que no van a devolver datos, se utiliza void

        public static void Initialize(HomeBankingContext context)
        {
            if (!context.Clients.Any())
            {
                var clients = new Client[]
                {

                    new Client{FirstName="Victor", LastName="Coronado", Email = "vcoronado@gmail.com", Password="123456"},
                    new Client{FirstName="Juan", LastName="Perez", Email = "sdgsdgsg@gmail.com", Password="125676"},
                    new Client{FirstName="Laura", LastName="Gomez", Email = "sggdsgfjt@gmail.com", Password="123896"}

                };

                context.Clients.AddRange(clients);

                //Guardar cambios

                context.SaveChanges();

            }
        }

    }
}
