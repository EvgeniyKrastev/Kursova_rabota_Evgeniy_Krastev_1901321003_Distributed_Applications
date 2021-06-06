﻿using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // add you finctions here

        [OperationContract]
        List<CarDTO> GetCars(); // old nationality

        [OperationContract]
        string PostCar(CarDTO CarDto);// old nationality

        [OperationContract]
        string DeleteCar(int id);// old nationality

        [OperationContract]
        List<BuyerDTO> GetBuyers();

        [OperationContract]
        string PostBuyer(BuyerDTO buyerDTOs);

        [OperationContract]
        CarDTO GetCarById(int id);

        [OperationContract]
        BuyerDTO GetBuyerById(int id);

        [OperationContract]
        string DeleteBuyer(int id);

        [OperationContract]
        List<OrderDTO> GetOrders();

        [OperationContract]
        string PostOrder(OrderDTO orderDTOs);

        [OperationContract]
        OrderDTO GetOrderById(int id);

        [OperationContract]
        string DeleteOrder(int id);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfService.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
