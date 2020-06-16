/// Created by: Kirk George
/// Copyright: Kirk George
/// Website: https://github.com/foozlemoozle?tab=repositories
/// See upload date for date created.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using com.keg.bootstrap;

namespace com.keg.bootstrap.tests
{
    public class TestBootStrap : BootStrap
    {
        // Start is called before the first frame update
        void Start()
        {
            Then( new TestManager() { name = "1", setupTimeMS = 500 } )
                .Then( new TestManager() { name = "2a", setupTimeMS = 1000 } )
                .And( new TestManager() { name = "2b", setupTimeMS = 2000 } )
                .Then( new TestManager() { name = "3", setupTimeMS = 3000, teardownTimeMS = 500 } )
                .InitManagers();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
