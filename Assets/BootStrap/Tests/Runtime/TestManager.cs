/// Created by: Kirk George
/// Copyright: Kirk George
/// Website: https://github.com/foozlemoozle?tab=repositories
/// See upload date for date created.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using com.keg.bootstrap;
using System.Threading.Tasks;

namespace com.keg.bootstrap.tests
{
    public class TestManager : IManager
    {
		public string name;
		public int setupTimeMS;
		public int teardownTimeMS;

		public async Task Setup( BootStrap strap, System.Action<IManager> onSetup, System.Action<IManager> onFail )
		{
			Debug.LogFormat( "<color=green>{0}</color> start at {1}", name, Time.fixedTime );

			Task setup = Task.Delay( setupTimeMS );
			await setup;

			Debug.LogFormat( "<color=green>{0}</color> end at {1}", name, Time.fixedTime );
			onSetup( this );
		}

		public void Update()
		{
		}

		public async Task Teardown( System.Action onTeardown )
		{
			Debug.LogFormat( "<color=red>{0}</color> start at {1}", name, Time.fixedTime );

			Task teardown = Task.Delay( teardownTimeMS );
			await teardown;

			Debug.LogFormat( "<color=red>{0}</color> end at {1}", name, Time.fixedTime );
			onTeardown();
		}
    }
}
