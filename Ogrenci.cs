

// T,K,M generic değerlerini sınıf nesne örneği oluştururken verilecektir.
// Sınıfa ait elemanlar bu generic tipler ile oluşturulabilir!!!

public class Ogrenci<T,K,M>
{
    public T TProp { get; set; }

    public M MProp { get; set; }

    public List<T> List { get; set; }

    public K GenericMetot1(M value1, M value2){

        return default(K);
    }

}

// Generic bir sınıf yazıp, bu sınıfı kendi koleksiyonunuz haline dönüşten ödev : 

// Kendi generic koleksiyonunuzu yazınız!!!

// Indexer nedir nasıl yazılır!!
// Yield nedir, yield return nasıl kullanılır
// yield : bir sınıfın içerisinde foreach ile gezebilme yetepi kazandırma işlemidir!!




