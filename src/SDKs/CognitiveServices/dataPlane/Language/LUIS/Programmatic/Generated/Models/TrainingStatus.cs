// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TrainingStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TrainingStatus
    {
        [EnumMember(Value = "NeedsTraining")]
        NeedsTraining,
        [EnumMember(Value = "InProgress")]
        InProgress,
        [EnumMember(Value = "Trained")]
        Trained
    }
    internal static class TrainingStatusEnumExtension
    {
        internal static string ToSerializedValue(this TrainingStatus? value)
        {
            return value == null ? null : ((TrainingStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TrainingStatus value)
        {
            switch( value )
            {
                case TrainingStatus.NeedsTraining:
                    return "NeedsTraining";
                case TrainingStatus.InProgress:
                    return "InProgress";
                case TrainingStatus.Trained:
                    return "Trained";
            }
            return null;
        }

        internal static TrainingStatus? ParseTrainingStatus(this string value)
        {
            switch( value )
            {
                case "NeedsTraining":
                    return TrainingStatus.NeedsTraining;
                case "InProgress":
                    return TrainingStatus.InProgress;
                case "Trained":
                    return TrainingStatus.Trained;
            }
            return null;
        }
    }
}
