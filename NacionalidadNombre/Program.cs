
using NacionalidadNombre.Class;

Console.WriteLine("Introduce un nombre: ");
NationalizeAPI nationalizeAPI = new NationalizeAPI();
NamePredict? namePredictResult = await nationalizeAPI.withHttpClientRaw(Console.ReadLine());
foreach (CountryPredict c in namePredictResult.country)
{
    Console.WriteLine($"pais: {c.country_id}, probabilidad {c.probability}");
}
 
 

