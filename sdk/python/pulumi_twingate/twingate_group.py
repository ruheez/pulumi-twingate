# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['TwingateGroupArgs', 'TwingateGroup']

@pulumi.input_type
class TwingateGroupArgs:
    def __init__(__self__, *,
                 is_authoritative: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 security_policy_id: Optional[pulumi.Input[str]] = None,
                 user_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        The set of arguments for constructing a TwingateGroup resource.
        :param pulumi.Input[bool] is_authoritative: Determines whether User assignments to this Group will override any existing assignments. Default is `true`. If set to
               `false`, assignments made outside of Terraform will be ignored.
        :param pulumi.Input[str] name: The name of the group
        :param pulumi.Input[str] security_policy_id: Defines which Security Policy applies to this Group. The Security Policy ID can be obtained from the
               `twingate_security_policy` and `twingate_security_policies` data sources.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] user_ids: List of User IDs that have permission to access the Group.
        """
        if is_authoritative is not None:
            pulumi.set(__self__, "is_authoritative", is_authoritative)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if security_policy_id is not None:
            pulumi.set(__self__, "security_policy_id", security_policy_id)
        if user_ids is not None:
            pulumi.set(__self__, "user_ids", user_ids)

    @property
    @pulumi.getter(name="isAuthoritative")
    def is_authoritative(self) -> Optional[pulumi.Input[bool]]:
        """
        Determines whether User assignments to this Group will override any existing assignments. Default is `true`. If set to
        `false`, assignments made outside of Terraform will be ignored.
        """
        return pulumi.get(self, "is_authoritative")

    @is_authoritative.setter
    def is_authoritative(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "is_authoritative", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the group
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="securityPolicyId")
    def security_policy_id(self) -> Optional[pulumi.Input[str]]:
        """
        Defines which Security Policy applies to this Group. The Security Policy ID can be obtained from the
        `twingate_security_policy` and `twingate_security_policies` data sources.
        """
        return pulumi.get(self, "security_policy_id")

    @security_policy_id.setter
    def security_policy_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "security_policy_id", value)

    @property
    @pulumi.getter(name="userIds")
    def user_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        List of User IDs that have permission to access the Group.
        """
        return pulumi.get(self, "user_ids")

    @user_ids.setter
    def user_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "user_ids", value)


@pulumi.input_type
class _TwingateGroupState:
    def __init__(__self__, *,
                 is_authoritative: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 security_policy_id: Optional[pulumi.Input[str]] = None,
                 user_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        Input properties used for looking up and filtering TwingateGroup resources.
        :param pulumi.Input[bool] is_authoritative: Determines whether User assignments to this Group will override any existing assignments. Default is `true`. If set to
               `false`, assignments made outside of Terraform will be ignored.
        :param pulumi.Input[str] name: The name of the group
        :param pulumi.Input[str] security_policy_id: Defines which Security Policy applies to this Group. The Security Policy ID can be obtained from the
               `twingate_security_policy` and `twingate_security_policies` data sources.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] user_ids: List of User IDs that have permission to access the Group.
        """
        if is_authoritative is not None:
            pulumi.set(__self__, "is_authoritative", is_authoritative)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if security_policy_id is not None:
            pulumi.set(__self__, "security_policy_id", security_policy_id)
        if user_ids is not None:
            pulumi.set(__self__, "user_ids", user_ids)

    @property
    @pulumi.getter(name="isAuthoritative")
    def is_authoritative(self) -> Optional[pulumi.Input[bool]]:
        """
        Determines whether User assignments to this Group will override any existing assignments. Default is `true`. If set to
        `false`, assignments made outside of Terraform will be ignored.
        """
        return pulumi.get(self, "is_authoritative")

    @is_authoritative.setter
    def is_authoritative(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "is_authoritative", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the group
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="securityPolicyId")
    def security_policy_id(self) -> Optional[pulumi.Input[str]]:
        """
        Defines which Security Policy applies to this Group. The Security Policy ID can be obtained from the
        `twingate_security_policy` and `twingate_security_policies` data sources.
        """
        return pulumi.get(self, "security_policy_id")

    @security_policy_id.setter
    def security_policy_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "security_policy_id", value)

    @property
    @pulumi.getter(name="userIds")
    def user_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        List of User IDs that have permission to access the Group.
        """
        return pulumi.get(self, "user_ids")

    @user_ids.setter
    def user_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "user_ids", value)


class TwingateGroup(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 is_authoritative: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 security_policy_id: Optional[pulumi.Input[str]] = None,
                 user_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        """
        Create a TwingateGroup resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] is_authoritative: Determines whether User assignments to this Group will override any existing assignments. Default is `true`. If set to
               `false`, assignments made outside of Terraform will be ignored.
        :param pulumi.Input[str] name: The name of the group
        :param pulumi.Input[str] security_policy_id: Defines which Security Policy applies to this Group. The Security Policy ID can be obtained from the
               `twingate_security_policy` and `twingate_security_policies` data sources.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] user_ids: List of User IDs that have permission to access the Group.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[TwingateGroupArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a TwingateGroup resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param TwingateGroupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(TwingateGroupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 is_authoritative: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 security_policy_id: Optional[pulumi.Input[str]] = None,
                 user_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = TwingateGroupArgs.__new__(TwingateGroupArgs)

            __props__.__dict__["is_authoritative"] = is_authoritative
            __props__.__dict__["name"] = name
            __props__.__dict__["security_policy_id"] = security_policy_id
            __props__.__dict__["user_ids"] = user_ids
        super(TwingateGroup, __self__).__init__(
            'twingate:index/twingateGroup:TwingateGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            is_authoritative: Optional[pulumi.Input[bool]] = None,
            name: Optional[pulumi.Input[str]] = None,
            security_policy_id: Optional[pulumi.Input[str]] = None,
            user_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None) -> 'TwingateGroup':
        """
        Get an existing TwingateGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] is_authoritative: Determines whether User assignments to this Group will override any existing assignments. Default is `true`. If set to
               `false`, assignments made outside of Terraform will be ignored.
        :param pulumi.Input[str] name: The name of the group
        :param pulumi.Input[str] security_policy_id: Defines which Security Policy applies to this Group. The Security Policy ID can be obtained from the
               `twingate_security_policy` and `twingate_security_policies` data sources.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] user_ids: List of User IDs that have permission to access the Group.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _TwingateGroupState.__new__(_TwingateGroupState)

        __props__.__dict__["is_authoritative"] = is_authoritative
        __props__.__dict__["name"] = name
        __props__.__dict__["security_policy_id"] = security_policy_id
        __props__.__dict__["user_ids"] = user_ids
        return TwingateGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="isAuthoritative")
    def is_authoritative(self) -> pulumi.Output[bool]:
        """
        Determines whether User assignments to this Group will override any existing assignments. Default is `true`. If set to
        `false`, assignments made outside of Terraform will be ignored.
        """
        return pulumi.get(self, "is_authoritative")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the group
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="securityPolicyId")
    def security_policy_id(self) -> pulumi.Output[str]:
        """
        Defines which Security Policy applies to this Group. The Security Policy ID can be obtained from the
        `twingate_security_policy` and `twingate_security_policies` data sources.
        """
        return pulumi.get(self, "security_policy_id")

    @property
    @pulumi.getter(name="userIds")
    def user_ids(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        List of User IDs that have permission to access the Group.
        """
        return pulumi.get(self, "user_ids")

