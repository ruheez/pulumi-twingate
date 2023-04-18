// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class TwingateResource extends pulumi.CustomResource {
    /**
     * Get an existing TwingateResource resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: TwingateResourceState, opts?: pulumi.CustomResourceOptions): TwingateResource {
        return new TwingateResource(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'twingate:index/twingateResource:TwingateResource';

    /**
     * Returns true if the given object is an instance of TwingateResource.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is TwingateResource {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === TwingateResource.__pulumiType;
    }

    /**
     * Restrict access to certain groups or service accounts
     */
    public readonly access!: pulumi.Output<outputs.TwingateResourceAccess | undefined>;
    /**
     * The Resource's IP/CIDR or FQDN/DNS zone
     */
    public readonly address!: pulumi.Output<string>;
    /**
     * Set a DNS alias address for the Resource. Must be a DNS-valid name string.
     */
    public readonly alias!: pulumi.Output<string | undefined>;
    /**
     * Determines whether assignments in the access block will override any existing assignments. Default is `true`. If set to
     * `false`, assignments made outside of Terraform will be ignored.
     */
    public readonly isAuthoritative!: pulumi.Output<boolean>;
    /**
     * Controls whether an "Open in Browser" shortcut will be shown for this Resource in the Twingate Client.
     */
    public readonly isBrowserShortcutEnabled!: pulumi.Output<boolean>;
    /**
     * Controls whether this Resource will be visible in the main Resource list in the Twingate Client.
     */
    public readonly isVisible!: pulumi.Output<boolean>;
    /**
     * The name of the Resource
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Restrict access to certain protocols and ports. By default or when this argument is not defined, there is no
     * restriction, and all protocols and ports are allowed.
     */
    public readonly protocols!: pulumi.Output<outputs.TwingateResourceProtocols | undefined>;
    /**
     * Remote Network ID where the Resource lives
     */
    public readonly remoteNetworkId!: pulumi.Output<string>;

    /**
     * Create a TwingateResource resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: TwingateResourceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: TwingateResourceArgs | TwingateResourceState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as TwingateResourceState | undefined;
            resourceInputs["access"] = state ? state.access : undefined;
            resourceInputs["address"] = state ? state.address : undefined;
            resourceInputs["alias"] = state ? state.alias : undefined;
            resourceInputs["isAuthoritative"] = state ? state.isAuthoritative : undefined;
            resourceInputs["isBrowserShortcutEnabled"] = state ? state.isBrowserShortcutEnabled : undefined;
            resourceInputs["isVisible"] = state ? state.isVisible : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["protocols"] = state ? state.protocols : undefined;
            resourceInputs["remoteNetworkId"] = state ? state.remoteNetworkId : undefined;
        } else {
            const args = argsOrState as TwingateResourceArgs | undefined;
            if ((!args || args.address === undefined) && !opts.urn) {
                throw new Error("Missing required property 'address'");
            }
            if ((!args || args.remoteNetworkId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'remoteNetworkId'");
            }
            resourceInputs["access"] = args ? args.access : undefined;
            resourceInputs["address"] = args ? args.address : undefined;
            resourceInputs["alias"] = args ? args.alias : undefined;
            resourceInputs["isAuthoritative"] = args ? args.isAuthoritative : undefined;
            resourceInputs["isBrowserShortcutEnabled"] = args ? args.isBrowserShortcutEnabled : undefined;
            resourceInputs["isVisible"] = args ? args.isVisible : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["protocols"] = args ? args.protocols : undefined;
            resourceInputs["remoteNetworkId"] = args ? args.remoteNetworkId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(TwingateResource.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering TwingateResource resources.
 */
export interface TwingateResourceState {
    /**
     * Restrict access to certain groups or service accounts
     */
    access?: pulumi.Input<inputs.TwingateResourceAccess>;
    /**
     * The Resource's IP/CIDR or FQDN/DNS zone
     */
    address?: pulumi.Input<string>;
    /**
     * Set a DNS alias address for the Resource. Must be a DNS-valid name string.
     */
    alias?: pulumi.Input<string>;
    /**
     * Determines whether assignments in the access block will override any existing assignments. Default is `true`. If set to
     * `false`, assignments made outside of Terraform will be ignored.
     */
    isAuthoritative?: pulumi.Input<boolean>;
    /**
     * Controls whether an "Open in Browser" shortcut will be shown for this Resource in the Twingate Client.
     */
    isBrowserShortcutEnabled?: pulumi.Input<boolean>;
    /**
     * Controls whether this Resource will be visible in the main Resource list in the Twingate Client.
     */
    isVisible?: pulumi.Input<boolean>;
    /**
     * The name of the Resource
     */
    name?: pulumi.Input<string>;
    /**
     * Restrict access to certain protocols and ports. By default or when this argument is not defined, there is no
     * restriction, and all protocols and ports are allowed.
     */
    protocols?: pulumi.Input<inputs.TwingateResourceProtocols>;
    /**
     * Remote Network ID where the Resource lives
     */
    remoteNetworkId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a TwingateResource resource.
 */
export interface TwingateResourceArgs {
    /**
     * Restrict access to certain groups or service accounts
     */
    access?: pulumi.Input<inputs.TwingateResourceAccess>;
    /**
     * The Resource's IP/CIDR or FQDN/DNS zone
     */
    address: pulumi.Input<string>;
    /**
     * Set a DNS alias address for the Resource. Must be a DNS-valid name string.
     */
    alias?: pulumi.Input<string>;
    /**
     * Determines whether assignments in the access block will override any existing assignments. Default is `true`. If set to
     * `false`, assignments made outside of Terraform will be ignored.
     */
    isAuthoritative?: pulumi.Input<boolean>;
    /**
     * Controls whether an "Open in Browser" shortcut will be shown for this Resource in the Twingate Client.
     */
    isBrowserShortcutEnabled?: pulumi.Input<boolean>;
    /**
     * Controls whether this Resource will be visible in the main Resource list in the Twingate Client.
     */
    isVisible?: pulumi.Input<boolean>;
    /**
     * The name of the Resource
     */
    name?: pulumi.Input<string>;
    /**
     * Restrict access to certain protocols and ports. By default or when this argument is not defined, there is no
     * restriction, and all protocols and ports are allowed.
     */
    protocols?: pulumi.Input<inputs.TwingateResourceProtocols>;
    /**
     * Remote Network ID where the Resource lives
     */
    remoteNetworkId: pulumi.Input<string>;
}
