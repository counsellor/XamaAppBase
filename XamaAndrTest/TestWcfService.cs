﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.8009
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ITestWcfService")]
public interface ITestWcfService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestWcfService/CheckLogPass", ReplyAction="http://tempuri.org/ITestWcfService/CheckLogPassResponse")]
    string CheckLogPass(string user);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestWcfService/GetOccupation", ReplyAction="http://tempuri.org/ITestWcfService/GetOccupationResponse")]
    string GetOccupation(string user);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface ITestWcfServiceChannel : ITestWcfService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class TestWcfServiceClient : System.ServiceModel.ClientBase<ITestWcfService>, ITestWcfService
{
    
    public TestWcfServiceClient()
    {
    }
    
    public TestWcfServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public TestWcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public TestWcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public TestWcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string CheckLogPass(string user)
    {
        return base.Channel.CheckLogPass(user);
    }
    
    public string GetOccupation(string user)
    {
        return base.Channel.GetOccupation(user);
    }
}
