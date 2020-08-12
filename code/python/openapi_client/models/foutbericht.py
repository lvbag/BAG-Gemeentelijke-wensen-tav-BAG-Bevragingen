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


class Foutbericht(object):
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
        'type': 'str',
        'title': 'str',
        'status': 'int',
        'detail': 'str',
        'instance': 'str',
        'code': 'str'
    }

    attribute_map = {
        'type': 'type',
        'title': 'title',
        'status': 'status',
        'detail': 'detail',
        'instance': 'instance',
        'code': 'code'
    }

    def __init__(self, type=None, title=None, status=None, detail=None, instance=None, code=None, local_vars_configuration=None):  # noqa: E501
        """Foutbericht - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._type = None
        self._title = None
        self._status = None
        self._detail = None
        self._instance = None
        self._code = None
        self.discriminator = None

        if type is not None:
            self.type = type
        if title is not None:
            self.title = title
        if status is not None:
            self.status = status
        if detail is not None:
            self.detail = detail
        if instance is not None:
            self.instance = instance
        if code is not None:
            self.code = code

    @property
    def type(self):
        """Gets the type of this Foutbericht.  # noqa: E501

        Link naar meer informatie over deze fout  # noqa: E501

        :return: The type of this Foutbericht.  # noqa: E501
        :rtype: str
        """
        return self._type

    @type.setter
    def type(self, type):
        """Sets the type of this Foutbericht.

        Link naar meer informatie over deze fout  # noqa: E501

        :param type: The type of this Foutbericht.  # noqa: E501
        :type: str
        """

        self._type = type

    @property
    def title(self):
        """Gets the title of this Foutbericht.  # noqa: E501

        Beschrijving van de fout  # noqa: E501

        :return: The title of this Foutbericht.  # noqa: E501
        :rtype: str
        """
        return self._title

    @title.setter
    def title(self, title):
        """Sets the title of this Foutbericht.

        Beschrijving van de fout  # noqa: E501

        :param title: The title of this Foutbericht.  # noqa: E501
        :type: str
        """

        self._title = title

    @property
    def status(self):
        """Gets the status of this Foutbericht.  # noqa: E501

        Http status code  # noqa: E501

        :return: The status of this Foutbericht.  # noqa: E501
        :rtype: int
        """
        return self._status

    @status.setter
    def status(self, status):
        """Sets the status of this Foutbericht.

        Http status code  # noqa: E501

        :param status: The status of this Foutbericht.  # noqa: E501
        :type: int
        """

        self._status = status

    @property
    def detail(self):
        """Gets the detail of this Foutbericht.  # noqa: E501

        Details over de fout  # noqa: E501

        :return: The detail of this Foutbericht.  # noqa: E501
        :rtype: str
        """
        return self._detail

    @detail.setter
    def detail(self, detail):
        """Sets the detail of this Foutbericht.

        Details over de fout  # noqa: E501

        :param detail: The detail of this Foutbericht.  # noqa: E501
        :type: str
        """

        self._detail = detail

    @property
    def instance(self):
        """Gets the instance of this Foutbericht.  # noqa: E501

        Uri van de aanroep die de fout heeft veroorzaakt  # noqa: E501

        :return: The instance of this Foutbericht.  # noqa: E501
        :rtype: str
        """
        return self._instance

    @instance.setter
    def instance(self, instance):
        """Sets the instance of this Foutbericht.

        Uri van de aanroep die de fout heeft veroorzaakt  # noqa: E501

        :param instance: The instance of this Foutbericht.  # noqa: E501
        :type: str
        """

        self._instance = instance

    @property
    def code(self):
        """Gets the code of this Foutbericht.  # noqa: E501

        Systeemcode die het type fout aangeeft  # noqa: E501

        :return: The code of this Foutbericht.  # noqa: E501
        :rtype: str
        """
        return self._code

    @code.setter
    def code(self, code):
        """Sets the code of this Foutbericht.

        Systeemcode die het type fout aangeeft  # noqa: E501

        :param code: The code of this Foutbericht.  # noqa: E501
        :type: str
        """
        if (self.local_vars_configuration.client_side_validation and
                code is not None and len(code) < 1):
            raise ValueError("Invalid value for `code`, length must be greater than or equal to `1`")  # noqa: E501

        self._code = code

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
        if not isinstance(other, Foutbericht):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, Foutbericht):
            return True

        return self.to_dict() != other.to_dict()
