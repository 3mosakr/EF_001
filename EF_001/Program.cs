namespace EF_001
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var context = new AppDbContext())
            {
                // Retrive collection of data
                foreach (var wallet in context.Wallets)
                {
                    Console.WriteLine(wallet);
                }

                // Retrive one element 
                //var itemId = 1;
                //var wallet = context.Wallets.FirstOrDefault(x => x.Id == itemId);
                //Console.WriteLine(wallet);

                // insert Data
                //var wallet = new Wallet { Holder = "Aly", Balance = 7000m };
                //context.Wallets.Add(wallet);
                //context.SaveChanges();

                //var wallet1 = new Wallet { Holder = "salah", Balance = 3000m };
                //var wallet2 = new Wallet { Holder = "ayman", Balance = 1000m };
                //var wallet3 = new Wallet { Holder = "issam", Balance = 4000m };
                //context.Wallets.Add(wallet1);
                //context.Wallets.Add(wallet2);
                //context.Wallets.Add(wallet3);
                //context.SaveChanges();



                // Update Data
                //var itemIdToUpdate = 3;
                //var wallet = context.Wallets.Single(x => x.Id == itemIdToUpdate);
                //wallet.Balance += 1200m;
                //context.SaveChanges();

                // Delete Data
                //var itemIdToDelete = 3;
                //var wallet = context.Wallets.Single(x => x.Id == itemIdToDelete);
                //context.Wallets.Remove(wallet);
                //context.SaveChanges();

                // Querying Data
                //var result = context.Wallets.Where(w => w.Balance <= 5000);
                //foreach (var wallet in result)
                //{
                //    Console.WriteLine(wallet);
                //}

                // Implement Transaction
                using (var transaction = context.Database.BeginTransaction())
                {
                    // transfere money from WalletId = 4 to WalletId = 5
                    var fromW = context.Wallets.Single(x => x.Id == 5);
                    var toW = context.Wallets.Single(x => x.Id == 6);
                    var amount = 500m;

                    fromW.Balance -= amount;
                    context.SaveChanges();
                    
                    toW.Balance -= amount;
                    context.SaveChanges();


                    transaction.Commit();
                }

                Console.WriteLine("----- after transaction -----");
                foreach (var wallet in context.Wallets)
                {
                    Console.WriteLine(wallet);
                }
            }

        }
    }
}
