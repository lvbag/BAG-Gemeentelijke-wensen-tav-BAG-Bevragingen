# coding: utf-8

"""
    Huidige bevragingen API

    Deze API levert actuele gegevens over adressen, adresseerbaar objecten en panden. Actueel betekent in deze API `zonder eindstatus`. De bron voor deze API is de basisregistratie adressen en gebouwen (BAG).  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Contact: bag@kadaster.nl
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from openapi_client.configuration import Configuration


class AdresseerbaarObjectEmbedded(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'adressen': 'list[AdresHalBasis]',
        'panden': 'list[PandHalBasis]'
    }

    attribute_map = {
        'adressen': 'adressen',
        'panden': 'panden'
    }

    def __init__(self, adressen=None, panden=None, local_vars_configuration=None):  # noqa: E501
        """AdresseerbaarObjectEmbedded - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._adressen = None
        self._panden = None
        self.discriminator = None

        if adressen is not None:
            self.adressen = adressen
        if panden is not None:
            self.panden = panden

    @property
    def adressen(self):
        """Gets the adressen of this AdresseerbaarObjectEmbedded.  # noqa: E501


        :return: The adressen of this AdresseerbaarObjectEmbedded.  # noqa: E501
        :rtype: list[AdresHalBasis]
        """
        return self._adressen

    @adressen.setter
    def adressen(self, adressen):
        """Sets the adressen of this AdresseerbaarObjectEmbedded.


        :param adressen: The adressen of this AdresseerbaarObjectEmbedded.  # noqa: E501
        :type: list[AdresHalBasis]
        """

        self._adressen = adressen

    @property
    def panden(self):
        """Gets the panden of this AdresseerbaarObjectEmbedded.  # noqa: E501


        :return: The panden of this AdresseerbaarObjectEmbedded.  # noqa: E501
        :rtype: list[PandHalBasis]
        """
        return self._panden

    @panden.setter
    def panden(self, panden):
        """Sets the panden of this AdresseerbaarObjectEmbedded.


        :param panden: The panden of this AdresseerbaarObjectEmbedded.  # noqa: E501
        :type: list[PandHalBasis]
        """

        self._panden = panden

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, AdresseerbaarObjectEmbedded):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, AdresseerbaarObjectEmbedded):
            return True

        return self.to_dict() != other.to_dict()
