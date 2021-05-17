<h1 align="center">How to use</h1>


`IResult`
```c#
public IResult Add(string text)
{
  if(text == null)
  {
    return new ErrorResult(); // ErrorResult = false
  }
  //add operation
  return new SuccessResult(); // SuccessResult = true
}
```
<hr/>

`ISingleDataResult<SingleData>`
```c#
public ISingleDataResult<Product> GetByProductId(int productId)
{
    return new SuccessSingleDataResult<Product>(_productService.GetProduct(product=>product==productId));
}
```
