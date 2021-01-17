#  DAY 3 

Bir bankada müşteri takibi yapmak için gerekli c# altyapısının oluşturulması.

## Customer.cs 

Müşterinin özelliklerini içerir. (Id - Name - Surname)

## CustomerManager.cs 

Müşterilere ait ekleme - silme -listeleme - güncelleme işlemlerinin yapıldığı fonksiyonları içerir.

Müşteri ekleme işlemi
```cs
 public void AddCustomer(Customer customer)
{
    customers.Add(customer);
}
```

Müşteri Listeleme işlemi
```cs
public Customer<List> GetCustomerList()
{
    foreach (var item in customers)
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Müşteri Adı :" + item.Name);
        Console.WriteLine("Müşteri Soyadı :" + item.Surname);
    }
    return customers
}
```

Müşteri Silme işlemi
```cs
public void DeleteCustomer(Customer customer)
{
    customers.Remove(customer);
    Console.WriteLine(customer.Name + " " + customer.Surname + " Has been deleted successfully");
}
```

Müşteri Güncelleme işlemi
```cs
public void UpdateCustomer(Customer customer)
{
    customer.Surname = customer.Surname + " UPDATED";
    customers.FirstOrDefault(x => x.Id == customer.Id).Surname = customer.Surname;
    Console.WriteLine(customer.Name + " " + customer.Surname + " Has been updated successfully");
}
```
