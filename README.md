### Requaried
```c#
using Results.Abstract;
using Results.State;
```
<hr/>

<h1 align="center">How to use</h1>

<hr/>

* [Net Standard Download](https://www.nuget.org/packages/Method.Results/)
* [Net Download](https://www.nuget.org/packages/Method.ResultsNet/)
* [Net Core Download](https://www.nuget.org/packages/Method.ResultsNetCore/)

<hr/>

`IResult default`
```c#
public IResult Add(string text)
{
  if(text == null)
  {
    return new ErrorResult(); // ErrorResult => false 
  }
  //add operation
  return new SuccessResult(); // SuccessResult => true
}
```
<hr/>

`IResult Overloads (message)`
```c#
public IResult Add(string text)
{
  if(text == null)
  {
    return new ErrorResult(message:"Not Null"); // ErrorResult => false and message
  }
  //add operation
  return new SuccessResult(message:" Success Add "); // SuccessResult => true and message
}
```
<hr/>

`IResult Overloads (message and tags)`
```c#
public IResult Add(string text)
{
  if(text == null)
  {
    return new ErrorResult(message:"Not Null","Errortag","ErrorTag1","ErrorTag2"); // ErrorResult => false , message and tags
  }
  //add operation
  return new SuccessResult(message:" Success Add ","Successtag","SuccessTag1","SuccessTag2"); // SuccessResult => true , message and tags
}
```

<hr/>

`ISingleDataResult<SingleData>`
```c#
public ISingleDataResult<Product> GetByProductId(int productId)
{
    // SuccessSingleDataResult<Product> => Product and true 
    return new SuccessSingleDataResult<Product>(_productDal.GetProduct(product => product.Id == productId)); 
}
```

<hr/>

`ISingleDataResult<SingleData> OverLoads`
```c#
public ISingleDataResult<Product> GetByProductId(int productId)
{
    // SuccessSingleDataResult<Product> => Product , true and message
    return new SuccessSingleDataResult<Product>(_productDal.GetProduct(product => product.Id == productId),message:" Data Listed ");  
}
```

<hr/>

`IListDataResult<ListData>`
```c#
public IListDataResult<Product> GetByCategory(int categoryId)
{
// SuccessListDataResult<Product> => List<Product> , true and count
  return new SuccessListDataResult<Product>(_productDal.GetAll(product => product.categoryId == categoryId)); 
}
```

<hr/>

`IListDataResult<ListData> OverLoads`
```c#
public IListDataResult<Product> GetByCategory(int categoryId)
{
  // SuccessListDataResult<Product> => List<Product> , true , message and count
  return new SuccessListDataResult<Product>(_productDal.GetAll(product => product.categoryId == categoryId),message:"data listed"); 
}
```

<hr/>

`IDataResult<Data>`
```c#
public IDataResult<Product> GetByProductId(int productId)
{
  // SuccessDataResult<Product> => Product and true
  return new SuccessDataResult<Product>(_productDal.Get(product => product.productId == productId)); 
}
```

<hr/>

`IDataResult<Data> OverLoads`
```c#
public IDataResult<Product> GetByProductId(int productId)
{
  // SuccessDataResult<Product> => Product , true , message and tags
  return new SuccessDataResult<Product>(_productDal.Get(product => product.productId == productId),message:"data listed","tag1","tag2"); 
}
```

<hr/>

`IDataResult<Data> List`
```c#
public IDataResult<List<Product>> GetAll()
{
  // SuccessDataResult<List<Product>> => Product List and true
  return new SuccessDataResult<List<Product>>(_productDal.GetAll()); 
}
```

<hr/>

`IDataResult<Data> List OverLoads`
```c#
public IDataResult<List<Product>> GetAll()
{
  // SuccessDataResult<List<Product>> => Product List, true , message and tags
  return new SuccessDataResult<List<Product>>(_productDal.GetAll(),message:"data listed","tag1","tag2"); 
}
```
