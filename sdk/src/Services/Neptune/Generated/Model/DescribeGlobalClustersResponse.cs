/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// This is the response object from the DescribeGlobalClusters operation.
    /// </summary>
    public partial class DescribeGlobalClustersResponse : AmazonWebServiceResponse
    {
        private List<GlobalCluster> _globalClusters = new List<GlobalCluster>();
        private string _marker;

        /// <summary>
        /// Gets and sets the property GlobalClusters. 
        /// <para>
        /// The list of global clusters and instances returned by this request.
        /// </para>
        /// </summary>
        public List<GlobalCluster> GlobalClusters
        {
            get { return this._globalClusters; }
            set { this._globalClusters = value; }
        }

        // Check to see if GlobalClusters property is set
        internal bool IsSetGlobalClusters()
        {
            return this._globalClusters != null && this._globalClusters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A pagination token. If this parameter is returned in the response, more records are
        /// available, which can be retrieved by one or more additional calls to <code>DescribeGlobalClusters</code>.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}