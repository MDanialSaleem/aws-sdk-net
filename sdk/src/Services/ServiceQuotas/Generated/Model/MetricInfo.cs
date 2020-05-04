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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// A structure that uses CloudWatch metrics to gather data about the service quota.
    /// </summary>
    public partial class MetricInfo
    {
        private Dictionary<string, string> _metricDimensions = new Dictionary<string, string>();
        private string _metricName;
        private string _metricNamespace;
        private string _metricStatisticRecommendation;

        /// <summary>
        /// Gets and sets the property MetricDimensions. 
        /// <para>
        /// A dimension is a name/value pair that is part of the identity of a metric. Every metric
        /// has specific characteristics that describe it, and you can think of dimensions as
        /// categories for those characteristics. These dimensions are part of the CloudWatch
        /// Metric Identity that measures usage against a particular service quota.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public Dictionary<string, string> MetricDimensions
        {
            get { return this._metricDimensions; }
            set { this._metricDimensions = value; }
        }

        // Check to see if MetricDimensions property is set
        internal bool IsSetMetricDimensions()
        {
            return this._metricDimensions != null && this._metricDimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the CloudWatch metric that measures usage of a service quota. This is
        /// a required field.
        /// </para>
        /// </summary>
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricNamespace. 
        /// <para>
        /// The namespace of the metric. The namespace is a container for CloudWatch metrics.
        /// You can specify a name for the namespace when you create a metric.
        /// </para>
        /// </summary>
        public string MetricNamespace
        {
            get { return this._metricNamespace; }
            set { this._metricNamespace = value; }
        }

        // Check to see if MetricNamespace property is set
        internal bool IsSetMetricNamespace()
        {
            return this._metricNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property MetricStatisticRecommendation. 
        /// <para>
        /// Statistics are metric data aggregations over specified periods of time. This is the
        /// recommended statistic to use when comparing usage in the CloudWatch Metric against
        /// your Service Quota.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string MetricStatisticRecommendation
        {
            get { return this._metricStatisticRecommendation; }
            set { this._metricStatisticRecommendation = value; }
        }

        // Check to see if MetricStatisticRecommendation property is set
        internal bool IsSetMetricStatisticRecommendation()
        {
            return this._metricStatisticRecommendation != null;
        }

    }
}