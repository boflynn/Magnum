// Copyright 2007-2010 The Apache Software Foundation.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Magnum.Routing
{
	using System;
	using System.Collections.Generic;


	public interface RoutingEngine
	{
		IEnumerable<T> Match<T>()
			where T : class;
	}


	public interface RoutingEngine<TContext> :
		RoutingEngine
	{
		/// <summary>
		/// Match a URI to the route defined in the routing engine
		/// </summary>
		/// <typeparam name="T">The context type to pass along with the routing request</typeparam>
		/// <param name="context">The context to pass along with the routing request</param>
		/// <param name="uri">The URI to route</param>
		/// <param name="matchCallback">Callback called if a matching route is found</param>
		void Route(TContext context, Action<RouteMatch<TContext>> matchCallback);
	}
}