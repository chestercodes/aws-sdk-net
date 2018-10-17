/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the GetRelationalDatabaseBlueprints operation.
    /// Returns a list of available database blueprints in Amazon Lightsail. A blueprint describes
    /// the major engine version of a database.
    /// 
    ///  
    /// <para>
    /// You can use a blueprint ID to create a new database that runs a specific database
    /// engine.
    /// </para>
    /// </summary>
    public partial class GetRelationalDatabaseBlueprintsRequest : AmazonLightsailRequest
    {
        private string _pageToken;

        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        /// A token used for advancing to a specific page of results for your get relational database
        /// blueprints request.
        /// </para>
        /// </summary>
        public string PageToken
        {
            get { return this._pageToken; }
            set { this._pageToken = value; }
        }

        // Check to see if PageToken property is set
        internal bool IsSetPageToken()
        {
            return this._pageToken != null;
        }

    }
}