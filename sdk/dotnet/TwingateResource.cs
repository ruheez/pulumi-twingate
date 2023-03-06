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
    [TwingateResourceType("twingate:index/twingateResource:TwingateResource")]
    public partial class TwingateResource : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Restrict access to certain groups or service accounts
        /// </summary>
        [Output("access")]
        public Output<Outputs.TwingateResourceAccess?> Access { get; private set; } = null!;

        /// <summary>
        /// The Resource's IP/CIDR or FQDN/DNS zone
        /// </summary>
        [Output("address")]
        public Output<string> Address { get; private set; } = null!;

        /// <summary>
        /// List of Group IDs that have permission to access the Resource, cannot be generated by Terraform and must be retrieved
        /// from the Twingate Admin Console or API
        /// </summary>
        [Output("groupIds")]
        public Output<ImmutableArray<string>> GroupIds { get; private set; } = null!;

        /// <summary>
        /// Determines whether assignments in the access block will override any existing assignments. Default is `true`. If set to
        /// `false`, assignments made outside of Terraform will be ignored.
        /// </summary>
        [Output("isAuthoritative")]
        public Output<bool> IsAuthoritative { get; private set; } = null!;

        /// <summary>
        /// Controls whether an "Open in Browser" shortcut will be shown for this Resource in the Twingate Client.
        /// </summary>
        [Output("isBrowserShortcutEnabled")]
        public Output<bool> IsBrowserShortcutEnabled { get; private set; } = null!;

        /// <summary>
        /// Controls whether this Resource will be visible in the main Resource list in the Twingate Client.
        /// </summary>
        [Output("isVisible")]
        public Output<bool> IsVisible { get; private set; } = null!;

        /// <summary>
        /// The name of the Resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Restrict access to certain protocols and ports. By default or when this argument is not defined, there is no
        /// restriction, and all protocols and ports are allowed.
        /// </summary>
        [Output("protocols")]
        public Output<Outputs.TwingateResourceProtocols?> Protocols { get; private set; } = null!;

        /// <summary>
        /// Remote Network ID where the Resource lives
        /// </summary>
        [Output("remoteNetworkId")]
        public Output<string> RemoteNetworkId { get; private set; } = null!;


        /// <summary>
        /// Create a TwingateResource resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TwingateResource(string name, TwingateResourceArgs args, CustomResourceOptions? options = null)
            : base("twingate:index/twingateResource:TwingateResource", name, args ?? new TwingateResourceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TwingateResource(string name, Input<string> id, TwingateResourceState? state = null, CustomResourceOptions? options = null)
            : base("twingate:index/twingateResource:TwingateResource", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/twingate-labs",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing TwingateResource resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TwingateResource Get(string name, Input<string> id, TwingateResourceState? state = null, CustomResourceOptions? options = null)
        {
            return new TwingateResource(name, id, state, options);
        }
    }

    public sealed class TwingateResourceArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Restrict access to certain groups or service accounts
        /// </summary>
        [Input("access")]
        public Input<Inputs.TwingateResourceAccessArgs>? Access { get; set; }

        /// <summary>
        /// The Resource's IP/CIDR or FQDN/DNS zone
        /// </summary>
        [Input("address", required: true)]
        public Input<string> Address { get; set; } = null!;

        [Input("groupIds")]
        private InputList<string>? _groupIds;

        /// <summary>
        /// List of Group IDs that have permission to access the Resource, cannot be generated by Terraform and must be retrieved
        /// from the Twingate Admin Console or API
        /// </summary>
        [Obsolete(@"The group_ids argument is now deprecated, and the new access block argument should be used instead. The group_ids argument will be removed in a future version of the provider.")]
        public InputList<string> GroupIds
        {
            get => _groupIds ?? (_groupIds = new InputList<string>());
            set => _groupIds = value;
        }

        /// <summary>
        /// Determines whether assignments in the access block will override any existing assignments. Default is `true`. If set to
        /// `false`, assignments made outside of Terraform will be ignored.
        /// </summary>
        [Input("isAuthoritative")]
        public Input<bool>? IsAuthoritative { get; set; }

        /// <summary>
        /// Controls whether an "Open in Browser" shortcut will be shown for this Resource in the Twingate Client.
        /// </summary>
        [Input("isBrowserShortcutEnabled")]
        public Input<bool>? IsBrowserShortcutEnabled { get; set; }

        /// <summary>
        /// Controls whether this Resource will be visible in the main Resource list in the Twingate Client.
        /// </summary>
        [Input("isVisible")]
        public Input<bool>? IsVisible { get; set; }

        /// <summary>
        /// The name of the Resource
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Restrict access to certain protocols and ports. By default or when this argument is not defined, there is no
        /// restriction, and all protocols and ports are allowed.
        /// </summary>
        [Input("protocols")]
        public Input<Inputs.TwingateResourceProtocolsArgs>? Protocols { get; set; }

        /// <summary>
        /// Remote Network ID where the Resource lives
        /// </summary>
        [Input("remoteNetworkId", required: true)]
        public Input<string> RemoteNetworkId { get; set; } = null!;

        public TwingateResourceArgs()
        {
        }
        public static new TwingateResourceArgs Empty => new TwingateResourceArgs();
    }

    public sealed class TwingateResourceState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Restrict access to certain groups or service accounts
        /// </summary>
        [Input("access")]
        public Input<Inputs.TwingateResourceAccessGetArgs>? Access { get; set; }

        /// <summary>
        /// The Resource's IP/CIDR or FQDN/DNS zone
        /// </summary>
        [Input("address")]
        public Input<string>? Address { get; set; }

        [Input("groupIds")]
        private InputList<string>? _groupIds;

        /// <summary>
        /// List of Group IDs that have permission to access the Resource, cannot be generated by Terraform and must be retrieved
        /// from the Twingate Admin Console or API
        /// </summary>
        [Obsolete(@"The group_ids argument is now deprecated, and the new access block argument should be used instead. The group_ids argument will be removed in a future version of the provider.")]
        public InputList<string> GroupIds
        {
            get => _groupIds ?? (_groupIds = new InputList<string>());
            set => _groupIds = value;
        }

        /// <summary>
        /// Determines whether assignments in the access block will override any existing assignments. Default is `true`. If set to
        /// `false`, assignments made outside of Terraform will be ignored.
        /// </summary>
        [Input("isAuthoritative")]
        public Input<bool>? IsAuthoritative { get; set; }

        /// <summary>
        /// Controls whether an "Open in Browser" shortcut will be shown for this Resource in the Twingate Client.
        /// </summary>
        [Input("isBrowserShortcutEnabled")]
        public Input<bool>? IsBrowserShortcutEnabled { get; set; }

        /// <summary>
        /// Controls whether this Resource will be visible in the main Resource list in the Twingate Client.
        /// </summary>
        [Input("isVisible")]
        public Input<bool>? IsVisible { get; set; }

        /// <summary>
        /// The name of the Resource
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Restrict access to certain protocols and ports. By default or when this argument is not defined, there is no
        /// restriction, and all protocols and ports are allowed.
        /// </summary>
        [Input("protocols")]
        public Input<Inputs.TwingateResourceProtocolsGetArgs>? Protocols { get; set; }

        /// <summary>
        /// Remote Network ID where the Resource lives
        /// </summary>
        [Input("remoteNetworkId")]
        public Input<string>? RemoteNetworkId { get; set; }

        public TwingateResourceState()
        {
        }
        public static new TwingateResourceState Empty => new TwingateResourceState();
    }
}
