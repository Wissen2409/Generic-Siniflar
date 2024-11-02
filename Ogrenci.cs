public class Ogrenci<T,K,M>
{
    public T TProp { get; set; }

    public M MProp { get; set; }

    public M GenericMetot1(M value1, M value2){

        return default(M);
    }

}

// 