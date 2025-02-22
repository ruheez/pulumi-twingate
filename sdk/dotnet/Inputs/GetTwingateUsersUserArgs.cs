// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TwingateLabs.Twingate.Inputs
{

    public sealed class GetTwingateUsersUserInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("email", required: true)]
        public Input<string> Email { get; set; } = null!;

        [Input("firstName", required: true)]
        public Input<string> FirstName { get; set; } = null!;

        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        [Input("isAdmin", required: true)]
        public Input<bool> IsAdmin { get; set; } = null!;

        [Input("lastName", required: true)]
        public Input<string> LastName { get; set; } = null!;

        [Input("role", required: true)]
        public Input<string> Role { get; set; } = null!;

        public GetTwingateUsersUserInputArgs()
        {
        }
        public static new GetTwingateUsersUserInputArgs Empty => new GetTwingateUsersUserInputArgs();
    }
}
