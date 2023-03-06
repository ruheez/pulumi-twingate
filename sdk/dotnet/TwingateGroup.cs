// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TwingateLabs.Twingate
{
    [TwingateResourceType("twingate:index/twingateGroup:TwingateGroup")]
    public partial class TwingateGroup : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the group
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;


        /// <summary>
        /// Create a TwingateGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TwingateGroup(string name, TwingateGroupArgs args, CustomResourceOptions? options = null)
            : base("twingate:index/twingateGroup:TwingateGroup", name, args ?? new TwingateGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TwingateGroup(string name, Input<string> id, TwingateGroupState? state = null, CustomResourceOptions? options = null)
            : base("twingate:index/twingateGroup:TwingateGroup", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/Twingate-Labs/pulumi-twingate/releases/download/v${VERSION}",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing TwingateGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TwingateGroup Get(string name, Input<string> id, TwingateGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new TwingateGroup(name, id, state, options);
        }
    }

    public sealed class TwingateGroupArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the group
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public TwingateGroupArgs()
        {
        }
        public static new TwingateGroupArgs Empty => new TwingateGroupArgs();
    }

    public sealed class TwingateGroupState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the group
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public TwingateGroupState()
        {
        }
        public static new TwingateGroupState Empty => new TwingateGroupState();
    }
}
