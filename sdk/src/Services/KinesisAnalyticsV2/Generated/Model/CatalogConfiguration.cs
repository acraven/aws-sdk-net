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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// The configuration parameters for the default AWS Glue database. You use this database
    /// for SQL queries that you write in a Kinesis Data Analytics Studio notebook.
    /// </summary>
    public partial class CatalogConfiguration
    {
        private GlueDataCatalogConfiguration _glueDataCatalogConfiguration;

        /// <summary>
        /// Gets and sets the property GlueDataCatalogConfiguration. 
        /// <para>
        /// The configuration parameters for the default AWS Glue database. You use this database
        /// for Apache Flink SQL queries and table API transforms that you write in a Kinesis
        /// Data Analytics Studio notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GlueDataCatalogConfiguration GlueDataCatalogConfiguration
        {
            get { return this._glueDataCatalogConfiguration; }
            set { this._glueDataCatalogConfiguration = value; }
        }

        // Check to see if GlueDataCatalogConfiguration property is set
        internal bool IsSetGlueDataCatalogConfiguration()
        {
            return this._glueDataCatalogConfiguration != null;
        }

    }
}