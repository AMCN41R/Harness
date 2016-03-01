﻿using System.Collections.Generic;
using Harness.Settings;
using MongoDB.Driver;

namespace Harness
{
    public interface IHarnessManager
    {
        IHarnessManager UsingSettings(string filepath);

        IHarnessManager UsingSettings(MongoConfiguration configuration);

        Dictionary<string, IMongoClient> Build();
    }
}
