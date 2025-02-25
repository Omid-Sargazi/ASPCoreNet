﻿using System.Xml.Serialization;
using Moq;
using MoqExample.Interfaces;

namespace MoqExample.Test;

public class UnitTest1
{
    // [Fact]
    public void Test1()
    {

    }

    // [Fact]
    public void Add_Test()
    {
        var mockCalculator = new Mock<ICalculator>();
        mockCalculator.Setup(x => x.Add(It.IsAny<int>(),It.IsAny<int>())).Returns(5);
        var result = mockCalculator.Object.Add(2,3);
        Assert.Equal(5, result);

    }

    // [Fact]
    public void Test_GetUserName()
    {
        var mockUserService =  new Mock<IUserService>();
        mockUserService.Setup(x => x.GetUserName(1)).Returns("OmidSa");
        var result = mockUserService.Object.GetUserName(1);
        Assert.Equal("OmidSa",result);
    }
    // [Fact]
    public void TestReadFile_throwException()
    {
        var mockFileReader = new Mock<IFileReader>();
        mockFileReader.Setup(x => x.ReadFile(It.IsAny<string>())).Throws(new FileNotFoundException());

        Assert.Throws<FileNotFoundException>(()=>mockFileReader.Object.ReadFile("invalid_path"));
    }

    // [Fact]
    public void Test_ConnectionString()
    {
        var mockAppSettings = new Mock<IAppSettings>();
        mockAppSettings.Setup(x => x.ConnectionString).Returns("Server=myServer;Database=Db;");
        var result = mockAppSettings.Object.ConnectionString;
        Assert.Equal("Server=myServer;Database=Db;",result);
    }

    // [Fact]
    public void Test_Log_Callback()
    {
        string loggedMessage = string.Empty;
        var mockLogger = new Mock<ILogger>();
        mockLogger.Setup(x => x.Log(It.IsAny<string>())).Callback<string>(msg => loggedMessage = msg);

        mockLogger.Object.Log("Test Message");
        Assert.Equal("Test Message",loggedMessage);
    }

    // [Fact]
    public void Test_TryParse()
    {
        var mockParse = new Mock<IParser>();
        mockParse.Setup(x => x.TyrParse(It.IsAny<string>(),out It.Ref<int>.IsAny)).Returns((string input, out int result)=>{
            result = 42;
            return true;
        });

        int output;
        var success = mockParse.Object.TyrParse("input", out output);
        Assert.Equal(42,output);
    }
    
    // [Fact]
    public void Test_Validate_RefParameter()
    {
        var mockValidator = new Mock<IValidator>();
        mockValidator.Setup(x => x.Validator(ref It.Ref<string>.IsAny)).Returns(true);

        string input = "test";
        var result = mockValidator.Object.Validator(ref input);
        Assert.Equal(true, result);
    }

    // [Fact]
    public void Test_Next_MultipleCalls()
    {
        var mockRandomGenerator = new Mock<IRandomGenerator>();
        mockRandomGenerator.SetupSequence(x => x.Next())
        .Returns(1)
        .Returns(2)
        .Returns(3);

        Assert.Equal(1, mockRandomGenerator.Object.Next());
        Assert.Equal(2, mockRandomGenerator.Object.Next());
        Assert.Equal(3, mockRandomGenerator.Object.Next());
    }


    [Fact]
    public async Task Test_GetDataAsync()
    {
        var mockApiClient = new Mock<IApiClient>();
        mockApiClient.Setup(x => x.GetDataAsunc()).ReturnsAsync("Mocked Data");

        var result = await mockApiClient.Object.GetDataAsunc();
        Assert.Equal("Mocked Data",result);
    }
}
