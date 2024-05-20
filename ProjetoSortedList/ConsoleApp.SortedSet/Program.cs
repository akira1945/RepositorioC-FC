

using ConsoleApp.SortedSet.Classes;

internal class Program
{
    private static void Main(string[] args)
    {

        // SortedSet<int> numbers = new SortedSet<int>();

        // // Retorna true, 5 é adicionado
        // bool added = numbers.Add(5);
        // // Retorna false, 5 não é adicionado novamente
        // added = numbers.Add(5);

        // // Retorna true, 5 é removido
        // bool removed = numbers.Remove(5);


        // // Retorna false, 5 não está presente
        // bool contains = numbers.Contains(5);

         #region Comparer
        // var people = new SortedSet<Person>(new AgeComparer());
        // people.Add(new Person { Name = "Alice", Age = 30 });
        // people.Add(new Person { Name = "Bob", Age = 25 });
         #endregion

         #region Interando

        // numbers = new SortedSet<int> { 7, 5, 1, 3 };
        // foreach (int number in numbers)
        // {
        //     Console.WriteLine(number);  // Saída: 1, 3, 5, 7
        // }

        // Console.WriteLine("Menor número: " + numbers.Min);  // Menor número: 1
        // Console.WriteLine("Maior número: " + numbers.Max);  // Maior número: 7


        // #endregion

        // #region Operações

        // SortedSet<int> setA = new SortedSet<int> { 1, 2, 3 };
        // SortedSet<int> setB = new SortedSet<int> { 2, 3, 4 };

        // // setA agora é {1, 2, 3, 4}
        // setA.UnionWith(setB);

        // // setA volta a ser {2, 3}
        // setA.IntersectWith(setB);

        // // setA agora é {3}
        // setA.ExceptWith(new SortedSet<int> { 2 });

        // // setA agora é {1, 4}
        // setA.SymmetricExceptWith(setB);

        // #endregion

        // #region  SubSet


        // setA = new SortedSet<int> { 1, 2, 3 };
        // setB = new SortedSet<int> { 1, 2, 3, 4, 5 };
        // SortedSet<int> setC = new SortedSet<int> { 2, 3, 6 };

        // // Verificando se setA é um subconjunto de setB
        // bool isSubset = setA.IsSubsetOf(setB);
        // Console.WriteLine($"setA é subconjunto de setB? {isSubset}");  // Saída: True

        // // Verificando se setB é um superconjunto de setA
        // bool isSuperset = setB.IsSupersetOf(setA);
        // Console.WriteLine($"setB é superconjunto de setA? {isSuperset}");  // Saída: True

        // // Verificando se setA é um subconjunto de setC
        // isSubset = setA.IsSubsetOf(setC);
        // Console.WriteLine($"setA é subconjunto de setC? {isSubset}");  // Saída: False

        // // Verificando se setC é um superconjunto de setA
        // isSuperset = setC.IsSupersetOf(setA);
        // Console.WriteLine($"setC é superconjunto de setA? {isSuperset}");  // Saída: False

        #endregion

        #region Exercicio

        #region Ex1
        GestorDeTarefas gestor = new GestorDeTarefas();
        gestor.AdicionarTarefa("Finalizar relatório", 2);
        gestor.AdicionarTarefa("Enviar e-mail", 1);
        gestor.AdicionarTarefa("Agendar reunião", 3);
        gestor.ListarTarefas();
        #endregion

        #region Ex2
        
        // // Criação do primeiro catálogo de produtos
        // CatalogoDeProdutos catalogo1 = new CatalogoDeProdutos();
        // catalogo1.AdicionarProduto("Notebook", "Eletrônicos", 1200.00m);
        // catalogo1.AdicionarProduto("Smartphone", "Eletrônicos", 800.00m);
        // catalogo1.AdicionarProduto("Tablet", "Eletrônicos", 600.00m);

        // // Criação do segundo catálogo de produtos
        // CatalogoDeProdutos catalogo2 = new CatalogoDeProdutos();
        // catalogo2.AdicionarProduto("Notebook", "Eletrônicos", 1200.00m);
        // catalogo2.AdicionarProduto("Smartphone", "Eletrônicos", 800.00m);
        // catalogo2.AdicionarProduto("Câmera", "Eletrônicos", 500.00m);

        // Console.WriteLine("Produtos antes da intersecção:");
        // catalogo1.MostrarProdutos();

        // // Realiza a intersecção do catalogo1 com os produtos do catalogo2
        // catalogo1.IntersectCatalogo(catalogo2.produtos);

        // Console.WriteLine("Produtos após a intersecção:");
        // catalogo1.MostrarProdutos();

        // // Realiza a união do catalogo1 com os produtos do catalogo2
        // catalogo1.UnionCatalogo(catalogo2.produtos);
        // Console.WriteLine("Produtos após a união:");
        // catalogo1.MostrarProdutos();

        // // Realiza a exclusão dos produtos de catalogo2 de catalogo1
        // catalogo1.ExceptCatalogo(catalogo2.produtos);
        // Console.WriteLine("Produtos após a exclusão dos itens de catalogo2:");
        // catalogo1.MostrarProdutos();

        #endregion

        #endregion
    }
}