#Requaried
```c#
using Results.Abstract;
using Results.State;
```
<hr/>
<h1 align="center">How to use</h1>
<hr/>

<a href="https://www.nuget.org/packages/Cagdas.Method.Results/">Download</a>

<hr/>

`IResult`
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

`IResult Overloads`
```c#
public IResult Add(string text)
{
  if(text == null)
  {
    return new ErrorResult("Not Null"); // ErrorResult => false and message
  }
  //add operation
  return new SuccessResult(" Success Add "); // SuccessResult => true and message
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
    return new SuccessSingleDataResult<Product>(_productDal.GetProduct(product => product.Id == productId)," Data Listed ");  
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
  return new SuccessListDataResult<Product>(_productDal.GetAll(product => product.categoryId == categoryId)); 
}
```
