using System;
using example_microservice.Common.Models;

namespace example_microservice.Common
{
	public interface IExampleClient
	{
        ExampleModel GetExampleModels();
        ExampleModel GetExampleModel(int id);
    }
}

